using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SampleNote.Main.Designer
{
    public class MainDriver : Form_Editor.GeneralFormArchitect
    {
        Utility.StringParserUtility stringParser = new Utility.StringParserUtility();
        TextBox lastInitialsBox = null;
        ContextMenu testMenu;
        public MonitorPassenger monitorObject;

        public MainDriver(Panel panelContents, Modules.API remoteApi, Dictionary<string, int> columnPosition, ToolTip dataExpansionTooltip)
        {
            this.panelContents = panelContents;
            this.remoteApi = remoteApi;
            this.dataExpansionTooltip = dataExpansionTooltip;
            this.columnPosition = columnPosition;
            this.logIndex = this.remoteApi.get_logcount();
            this.isMonitor = false;

            this.panelContents.Controls.Clear();

            this.panelContents.Parent.SizeChanged += (s, e) => { this.ListSizePropertyChanged(); };
            this.history = new Modules.History();

            this.dataExpansionTooltip = dataExpansionTooltip;

            this.colorVariant.Add(stringParser.parseColor(configurationDesigner["log_color.variant1"]));
            this.colorVariant.Add(stringParser.parseColor(configurationDesigner["log_color.variant2"]));
            this.testColor.Add(stringParser.parseColor(configurationDesigner["test_color.idle"]));
            this.testColor.Add(stringParser.parseColor(configurationDesigner["test_color.started"]));
            this.testColor.Add(stringParser.parseColor(configurationDesigner["test_color.finished"]));

            int logsDisplayed = 0;
            for (int index = 1; index <= this.logIndex; index++)
            {
                if (logsDisplayed == displayableLogsCount)
                {
                    break;
                }

                if (!remoteApi.get_logdone(index))
                {
                    Panel logObject = CreateLog(index);
                    // I wanted the CreateLog method to return both the Panel object and LogData dictionary.
                    Dictionary<string, string[]> logData = remoteApi.fetch_log(index);
                    ApplyLogFunctionality(logObject, logData);
                    logsDisplayed++;
                    previousLogIndex = index;
                }
            }

            setup = false;
            this.testMenu = new ContextMenu();
            MenuItem idle = new MenuItem("Idle");
            MenuItem start = new MenuItem("Start");
            MenuItem finish = new MenuItem("Finish");
            this.testMenu.MenuItems.Add(idle);
            this.testMenu.MenuItems.Add(start);
            this.testMenu.MenuItems.Add(finish);
            idle.Click += (s, e) => { this.PromptInitialsVerification(testMenu.SourceControl as Button, elevate: 1); };
            start.Click += (s, e) => { this.PromptInitialsVerification(testMenu.SourceControl as Button, elevate: 2); };
            finish.Click += (s, e) => { this.PromptInitialsVerification(testMenu.SourceControl as Button, elevate: 3); };

        }


        public void ApplyLogFunctionality(Panel logObject, Dictionary<string, string[]> logData)
        {
            // Give Sample Number Events
            Label sampleNumber;
            FlowLayoutPanel testsPanel;

            try
            {
                sampleNumber = (Label)logObject.Controls.Find("Sample Number", false)[0];
                testsPanel = (FlowLayoutPanel)logObject.Controls.Find($"Log Panel. {logObject.Name}", false)[0];
            }
            catch
            {
                Console.WriteLine("Error Occured : R. Missing Log Object");
                return;
            }

            sampleNumber.MouseUp += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    DialogResult dialogData = MessageBox.Show("Would you like to print a label?", "Print Another Label", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (dialogData == DialogResult.Yes)
                    {
                        new Modals.DYMOLabel_PrintPreview(logData).ShowDialog();
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    DialogResult dialogData = MessageBox.Show("Would you like to DELETE this log?", "Confirm Delete Log", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (dialogData == DialogResult.Yes)
                    {
                        new Modals.LogDeletionConfirmation(remoteApi, logIndex, logData["Sample Number"][0], this, logObject).ShowDialog();
                    }
                }
            };


            sampleNumber.MouseEnter += (s, e) => { sampleNumber.ForeColor = Color.FromArgb(200, 200, 200); };
            sampleNumber.MouseLeave += (s, e) => { sampleNumber.ForeColor = Color.White;};

            foreach (Control testObject in testsPanel.Controls)
            {
                Button btnTestObject = testObject as Button;
                btnTestObject.MouseDown += TestObjectClicked;
                btnTestObject.ContextMenu = testMenu;
            }
        }

        public void PromptInitialsVerification(Button testObject, int elevate = -1)
        {
            TextBox initialsBox = new TextBox();
            initialsBox.Dock = DockStyle.Fill;
            initialsBox.Name = "initials_box";
            initialsBox.Text = "Initials";
            // Highlights Text
            initialsBox.SelectionStart = 0;
            initialsBox.SelectionLength = initialsBox.Text.Length;
            initialsBox.BackColor = Color.FromArgb(230, 230, 230);

            initialsBox.Tag = elevate != -1 ? elevate : -1;
            Console.WriteLine($"Initials Tag Value: {initialsBox.Tag.ToString()}");

            if (lastInitialsBox != null && lastInitialsBox.Parent != testObject)
            {
                lastInitialsBox.Dispose();
            }

            lastInitialsBox = initialsBox;
            initialsBox.KeyUp += ParseInitialsObject;

            testObject.Controls.Add(initialsBox);
            initialsBox.Focus();
        }

        public void TestObjectClicked(object sender, MouseEventArgs e)
        {
            Button testButton = sender as Button;
            if (e.Button == MouseButtons.Right)
            {
                Button button = sender as Button;
                button.ContextMenu = this.testMenu;
                return;
            }

            if (testButton.HasChildren)
            {
                Console.WriteLine("Cancelled Call: R. Has Children");
                return;
            }

            PromptInitialsVerification(testButton);
        }

        public void ParseInitialsObject(object sender, KeyEventArgs e)
        {
            TextBox initialsBox = sender as TextBox;
            Button testButton = initialsBox.Parent as Button;
            Panel logPanel = testButton.Parent.Parent as Panel;
            string sampleNumberText = logPanel.Controls.Find("Sample Number", false)[0].Text;
            int logIndex = Int32.Parse(logPanel.Name.Replace("Log. ", String.Empty));

            if (e.KeyCode == Keys.Enter)
            {
                string textboxData = initialsBox.Text;

                if (!initialsBox.IsDisposed)
                {
                    int newTestStatus;
                    if (initialsBox.Tag != null)
                    {
                        Console.WriteLine("Reading elavation status: " + initialsBox.Tag.ToString());
                        newTestStatus = remoteApi.push_teststatus(logIndex, testButton.Text, overwrite_status: (int)initialsBox.Tag);

                    }
                    else
                    {
                        newTestStatus = remoteApi.push_teststatus(logIndex, testButton.Text);
                    }
                    
                    // Log is Complete
                    if (newTestStatus == 0)
                    {
                        monitorObject.PassTestObjectColor(testButton.Parent.Parent.Name, testButton.Text, 3);
                        SetTestObjectColor(testButton, 3);
                        monitorObject.PassHideLogObject(logPanel.Name, logCompleted: true);
                        HideLogObject(logPanel, logCompleted: true);
                        history.write(sampleNumberText, String.Format("{0} completed log", initialsBox.Text.ToUpper()));
                    }
                    else
                    {
                        monitorObject.PassTestObjectColor(testButton.Parent.Parent.Name, testButton.Text, newTestStatus);
                        SetTestObjectColor(testButton, newTestStatus);
                        history.write(sampleNumberText, $"{initialsBox.Text.ToUpper()} modified {testButton.Text} status. Test Status: [{newTestStatus}]");

                    }

                    initialsBox.Dispose();
                }
                // CLOSE INITIALS BOX
                else if (e.KeyCode == Keys.Escape)
                {
                    if (!initialsBox.IsDisposed)
                    {
                        initialsBox.Dispose();
                    }
                }
            }
        }

        public override void SetTestObjectColor(Control testObject, int newTestStatus)
        {
            testObject.ForeColor = testColor[newTestStatus - 1];
        }
    }

}
