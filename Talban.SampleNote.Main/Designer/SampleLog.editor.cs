using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SampleNote.Main.Forms
{
    public class SampleLog_FormEditor
    {
        // Listing of Variables
        Utility.ConfigUtility ConfigurationDesigner = new Utility.ConfigUtility(@"./config/usercontrol.designer.config");
        Utility.StringParserUtility StringParser = new Utility.StringParserUtility();
        Utility.TweenUtility TweenUtility = new Utility.TweenUtility();
        Modules.DYMOLabelWriter DymoLabelWriter = new Modules.DYMOLabelWriter();
        Modules.History history;
         Modules.API remoteAPI;
        List<Color> colorVariant = new List<Color>();
        List<Color> testColors = new List<Color>();
        Dictionary<string, int> columnPositions;
        // Construct controls instances
        Panel panelContents;
        ContextMenu testMenu;
        ToolTip dataExpansionTooltip;
        TextBox lastInitialsBox = null;
        // Initialize variables
        static int lastDisplayedLogIndex, log_index; // PreviousLogIndex
        const int maxLogsDisplayable = 17;
        float fontSize = 12f;
        int panelHeight;
        bool isMonitor = false;
        public SampleLog_FormEditor monitor_object;
        bool setup = false;
        // Prepare the form editor class variables
        public SampleLog_FormEditor(Panel panelContents, Modules.API remoteAPI, Dictionary<string, int> columnPositions, ToolTip dataExpansionTooltip)
        {
            Console.WriteLine("Constructed SampleLog Editor");
            if (panelContents.FindForm().Name == "Monitor")
            {
                fontSize = 16f;
                isMonitor = true;
            }
            setup = true;
            this.columnPositions = columnPositions;
            this.remoteAPI = remoteAPI;
            this.panelContents = panelContents;
            this.panelContents.Controls.Clear();
            this.panelContents.Parent.SizeChanged += panelContents_SizeChanged;
            this.history = new Modules.History();

            this.dataExpansionTooltip = dataExpansionTooltip;
            this.colorVariant.Add(
                StringParser.parseColor(ConfigurationDesigner["log_color.variant1"]));
            this.colorVariant.Add(
                StringParser.parseColor(ConfigurationDesigner["log_color.variant2"]));
            this.testColors.Add(
                StringParser.parseColor(ConfigurationDesigner["test_color.idle"]));
            this.testColors.Add(
               StringParser.parseColor(ConfigurationDesigner["test_color.started"]));
            this.testColors.Add(
               StringParser.parseColor(ConfigurationDesigner["test_color.finished"]));

            // Fill Log with forms
            log_index = remoteAPI.get_logcount();

            int logsDisplayed = 0;
            for (int index = 1; index <= log_index; index++)
            {
                if (logsDisplayed == maxLogsDisplayable)
                {
                    break;
                }

                if (!remoteAPI.get_logdone(index))
                {
                    createLog(index);
                    logsDisplayed++;
                    lastDisplayedLogIndex = index;
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
            idle.Click += (s, e) => { promptInitialsBox(testMenu.SourceControl as Button, elevate:1); };
            start.Click += (s, e) => { promptInitialsBox(testMenu.SourceControl as Button, elevate:2); };
            finish.Click += (s, e) => { promptInitialsBox(testMenu.SourceControl as Button, elevate:3); };

        }
        // Resize the contents in the contents panel whenever the form is resized
        private void panelContents_SizeChanged(object sender, EventArgs e)
        {
            foreach (Panel pan in panelContents.Controls)
            {
                pan.Width = panelContents.Width;

                FlowLayoutPanel testPanel = pan.Controls.Find(string.Format("Log Panel. {0}", pan.Name), false)[0] as FlowLayoutPanel;
                testPanel.Size = new Size(panelContents.Width - columnPositions["Tests Required"], panelHeight);
                testPanel.Location = new Point(columnPositions["Tests Required"], testPanel.Location.Y);
            }
        }
        // Recolors all the logs that are in the sample log container based on index
        private void recolorPattern()
        {
            for (int panel_index = 0; panel_index < panelContents.Controls.Count; panel_index++)
            {
                panelContents.Controls[panel_index].BackColor = this.colorVariant[(panel_index + 1) % 2];
            }
        }

        public void removeLog(Panel logPanel)
        {
            hide_log(logPanel, complete: true, color:Color.FromArgb(170, 0, 0));
            monitor_object.hide_log(monitor_object.find_monitorlog(logPanel.Name), complete: true, color: Color.FromArgb(170, 0, 0));
        }

        // Creates a log using data from the log index
        
        public void createLog(int log_index, bool print_dymo_label=false)
        {
            //Console.WriteLine("Constructing Log");
            panelHeight = Int32.Parse(ConfigurationDesigner["panel.height"]);
            Dictionary<string, string[]> logData = remoteAPI.fetch_log(log_index);
            int yPosition = 22;

            Panel logPanel = new Panel();
            logPanel.Name = log_index.ToString(); // string.Format("Log. {0}", log_index);
            logPanel.BackColor = this.colorVariant[(panelContents.Controls.Count+1) % 2];
            logPanel.ForeColor = Color.White;
            logPanel.Font = new Font("Trebuchet Ms", fontSize);
            logPanel.Margin = new Padding(0, 0, 0, 0);
            logPanel.Height = panelHeight;
            logPanel.Width = panelContents.Width;

            FlowLayoutPanel testsPanel = new FlowLayoutPanel();
            testsPanel.Name = string.Format("Log Panel. {0}", log_index);
            testsPanel.FlowDirection = FlowDirection.LeftToRight;
            testsPanel.Anchor = AnchorStyles.Right & AnchorStyles.Left;
            testsPanel.WrapContents = false;
            testsPanel.AutoScroll = true;
            testsPanel.Tag = "Tests Required";
            //testsPanel.Dock = DockStyle.Right;
            testsPanel.Location = new Point(columnPositions["Tests Required"], yPosition-5); //yPosition-10
            testsPanel.Size = new Size(panelContents.Width - columnPositions["Tests Required"], panelHeight-yPosition);

            Label sampleNumber = new Label(); ;
            if (!isMonitor)
            {
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
                            //new Modals.LogDeletionConfirmation(remoteAPI, log_index, logData["Sample Number"][0], this, logPanel).ShowDialog();
                        }
                    }
                    
                };

                sampleNumber.MouseEnter += (s, e) =>
                {
                    sampleNumber.ForeColor = Color.FromArgb(200, 200, 200);
                };

                sampleNumber.MouseLeave += (s, e) =>
                {
                    sampleNumber.ForeColor = Color.White;
                };

            }
            /*
            else
            {
                sampleNumber = new Button();
                sampleNumber.FlatStyle = FlatStyle.Flat;
                sampleNumber.FlatAppearance.BorderSize = 0;

            }
            */

            sampleNumber.Name = "Sample Number"; // Make it easier to find
            sampleNumber.Text = logData["Sample Number"][0];
            sampleNumber.ForeColor = Color.White;
            sampleNumber.Location = new Point(columnPositions["Sample Number"], yPosition);
            sampleNumber.Font = new Font(sampleNumber.Font.Name, (float)14.25);
            sampleNumber.Tag = "Sample Number";
            sampleNumber.AutoSize = false;
            sampleNumber.Width = columnPositions["Project Number"] - sampleNumber.Left;

            Label projectNumber = new Label();
            projectNumber.Text = logData["Project Number"][0];
            projectNumber.ForeColor = Color.White;
            projectNumber.Location = new Point(columnPositions["Project Number"], yPosition);
            
            projectNumber.Tag = "Project Number";
            projectNumber.AutoSize = false;
            projectNumber.Width = columnPositions["Project Name"] - projectNumber.Left;

            Label projectName = new Label();
            projectName.Text = logData["Project Name"][0];
            projectName.ForeColor = Color.White;
            projectName.Location = new Point(columnPositions["Project Name"], yPosition);
            projectName.Tag = "Project Name";
            projectName.AutoSize = false;
            projectName.Width = columnPositions["Client Name"] - projectName.Left;

            Label clientName = new Label();
            clientName.Text = logData["Client Name"][0];
            clientName.ForeColor = Color.White;
            clientName.Location = new Point(columnPositions["Client Name"], yPosition);
            clientName.Tag = "Client Name";
            clientName.AutoSize = false;
            clientName.Width = columnPositions["Date Recieved"] - clientName.Left;

            Label dateRecieved = new Label();
            dateRecieved.Text = logData["Date Recieved"][0];
            dateRecieved.ForeColor = Color.White;
            dateRecieved.Location = new Point(columnPositions["Date Recieved"], yPosition);
            dateRecieved.Tag = "Date Recieved";
            DateTime timePlaceholder;
            if (DateTime.TryParse(logData["Date Recieved"][0], out timePlaceholder))
            { 
                dataExpansionTooltip.SetToolTip(dateRecieved, (timePlaceholder.ToString("hh:mmtt")));
            }
            dateRecieved.AutoSize = false;
            dateRecieved.Width = columnPositions["Samp. Description"] - dateRecieved.Left;

            Label sampleDescription = new Label();
            sampleDescription.Text = logData["Samp. Description"][0];
            sampleDescription.ForeColor = Color.White;
            sampleDescription.Location = new Point(columnPositions["Samp. Description"], yPosition);
            sampleDescription.Tag = "Samp. Description";
            sampleDescription.AutoSize = false;
            sampleDescription.Width = columnPositions["Samp. Location"] - sampleDescription.Left;

            Label sampleLocation = new Label();
            sampleLocation.Text = logData["Samp. Location"][0];
            sampleLocation.ForeColor = Color.White;
            sampleLocation.Location = new Point(columnPositions["Samp. Location"], yPosition);
            sampleLocation.Tag = "Samp. Location";
            sampleLocation.AutoSize = false;
            sampleLocation.Width = columnPositions["Tests Required"] - sampleLocation.Left;
            Console.WriteLine("Sample Location Data:" + logData["Samp. Location"][0]);
            int prevRight = 0;
            foreach (string testName in logData["Tests Required"])
            {
                if (String.IsNullOrEmpty(testName))
                {
                    break;
                }
                dynamic testButton;
                if (isMonitor)
                {
                    testButton = new Label();
                }
                else
                {
                    testButton = new Button();
                    (testButton as Button).MouseDown += TestButton_MouseClick;
                    testButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    testButton.FlatAppearance.BorderSize = 0;
                    testButton.FlatAppearance.BorderColor = logPanel.BackColor;
                }
               
                testButton.AutoSize = true;
                testButton.Anchor = AnchorStyles.Left;
                testButton.FlatStyle = FlatStyle.Flat;
                testButton.Text = testName.Substring(1);
                testButton.ForeColor = Color.White;
                testButton.ContextMenu = testMenu;
                color_testButton(testButton, Int16.Parse(testName.Substring(0, 1)));
                //testRequired.Location = new Point(prevRight, yPosition-4);
                testButton.TextAlign = ContentAlignment.MiddleLeft;
                testButton.Height = 30;
                
                prevRight = testButton.Location.X + testButton.Width + 3;
                testsPanel.Controls.Add(testButton);

                
            }
            
            // Print the Label if the argument allows it
            if (print_dymo_label)
            {
                // Pass the log data dictionary to the function
                DymoLabelWriter.PrintLabel(logData);
            }

            // Add all the sub columns to log panel
            logPanel.Controls.Add(sampleNumber);
            logPanel.Controls.Add(projectNumber);
            logPanel.Controls.Add(projectName);
            logPanel.Controls.Add(clientName);
            logPanel.Controls.Add(dateRecieved);
            logPanel.Controls.Add(sampleDescription);
            logPanel.Controls.Add(sampleLocation);
            logPanel.Controls.Add(testsPanel);
            panelContents.Controls.Add(logPanel);

            // Copy to monitor
            if (setup == false && isMonitor == false)
            {
                monitor_object.createLog(log_index);
            }
        }
        // Prompts a textbox in place of the button to recieve the user initials
        private void promptInitialsBox(Button testButton, int elevate=-1)
        {
            TextBox initialsBox = new TextBox();
            initialsBox.Dock = DockStyle.Fill;
            initialsBox.Name = "initials_box";
            initialsBox.Text = "Initials";
            // Highlights Text
            initialsBox.SelectionStart = 0;
            initialsBox.SelectionLength = initialsBox.Text.Length;
            initialsBox.BackColor = Color.FromArgb(230, 230, 230);

            if (elevate != -1)
            {
                Console.WriteLine("Raising Elevation");
                initialsBox.Tag = elevate;
            }

            if (lastInitialsBox != null && lastInitialsBox.Parent != testButton)
            {
                lastInitialsBox.Dispose();
            }

            lastInitialsBox = initialsBox;
            initialsBox.KeyUp += InitialsBox_KeyUp;

            testButton.Controls.Add(initialsBox);
            initialsBox.Focus();
        }
        // Determine whether or not to prompt the elevation context menu or display a textbox
        private void TestButton_MouseClick(object sender, MouseEventArgs e)
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
                Console.WriteLine("Rejecting Call. Has Children");
                return;
            }

            promptInitialsBox(testButton);

        }
        // Simply edits the test buttons color
        private void color_testButton(Control testButton, int new_testStatus)
        {
            // Console.WriteLine("Writing Test Index: " + (new_testStatus - 1).ToString());
            testButton.ForeColor = testColors[new_testStatus - 1];
        }
        // This one needs to loop through the contents to find the button similar to the one in the user control
        private void monitor_colorTestButton(string panel_name, string button_text, int new_testStatus)
        {
            Control[] test_panels = panelContents.Controls.Find(panel_name, true);

            foreach (Control panel in test_panels)
            {
                foreach (Control testButton in panel.Controls)
                {
                    if (testButton.Text == button_text)
                    {
                        testButton.ForeColor = testColors[new_testStatus - 1];
                    }
                }
            }
        }
        private Panel find_monitorlog(string log_name)
        {
            return (Panel)panelContents.Controls.Find(log_name, false)[0];
        }
        // Runs a tweenUtility and a recolor to indicate test completion, then remove log and add a new one
        private void hide_log(Panel log, bool complete=false, Color? color=null)
        {
            if (complete)
            {
                Console.WriteLine("Log has been completed. Hiding it");
                log.BackColor = color.GetValueOrDefault(Color.FromArgb(255, 131, 255, 94));
                foreach (Control control in log.Controls)
                {
                    if (control.HasChildren)
                    {
                        foreach (Control subControl in control.Controls)
                        {
                            subControl.ForeColor = Color.FromArgb(40, 40, 40);
                            subControl.Enabled = false;
                        }
                    }
                    control.ForeColor = Color.FromArgb(40, 40, 40);
                }
                Timer timer = new Timer();
                timer.Enabled = true;
                timer.Interval = 1500;
                timer.Tick += (s, e) =>
                {
                    TweenUtility.TweenSize(log, new Point(log.Width, 0), 1, 10);
                    timer.Enabled = false;
                    log.Dispose();
                    timer.Dispose();
                    recolorPattern();
                    log_index = remoteAPI.get_logcount();
                };

                lastDisplayedLogIndex++;

                // Display the next available log.  
                for (int index = lastDisplayedLogIndex; index < log_index; index++)
                {
                    if (!remoteAPI.get_logdone(lastDisplayedLogIndex))
                    {
                        createLog(index);
                        lastDisplayedLogIndex++;
                        lastDisplayedLogIndex = index;
                        break;
                    }
                }
               
            }
        }
        // Get key input in textbox.
        private void InitialsBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox initialsBox = sender as TextBox;
            Button testButton = initialsBox.Parent as Button;
            Panel logPanel = testButton.Parent.Parent as Panel;
            string sampleNumberText = logPanel.Controls.Find("Sample Number", false)[0].Text;
            int logIndex = Int32.Parse(logPanel.Name.Replace("Log. ", String.Empty));

            // PUSH CHANGE
            if (e.KeyCode == Keys.Enter)
            {
                string textbox_data = initialsBox.Text;
                
                if (!initialsBox.IsDisposed)
                {
                    int new_teststatus;
                    if (initialsBox.Tag != null)
                    {
                        Console.WriteLine("Reading elavation status: " + initialsBox.Tag.ToString());
                        new_teststatus = remoteAPI.push_teststatus(logIndex, testButton.Text, overwrite_status: (int)initialsBox.Tag);

                    }
                    else
                    {
                        new_teststatus = remoteAPI.push_teststatus(logIndex, testButton.Text);
                    }

                    // Log is Complete
                    if (new_teststatus == 0)
                    {
                        color_testButton(testButton, 3);
                        hide_log(logPanel, complete: true);
                        if (isMonitor == false)
                        {
                            monitor_object.monitor_colorTestButton(testButton.Parent.Name, testButton.Text, 3);
                            monitor_object.hide_log(monitor_object.find_monitorlog(logPanel.Name), complete: true);
                            history.write(sampleNumberText, String.Format("{0} completed log", initialsBox.Text.ToUpper()));

                        }
                    }
                    else
                    {
                        color_testButton(testButton, new_teststatus);
                        if (isMonitor == false)
                        {
                            monitor_object.monitor_colorTestButton(testButton.Parent.Name, testButton.Text, new_teststatus);
                            history.write(sampleNumberText, String.Format("{0} modified {1} status. Test Status: [{2}]", initialsBox.Text.ToUpper(), testButton.Text, new_teststatus));
                        }
                    }

                    initialsBox.Dispose();
                }
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
}
