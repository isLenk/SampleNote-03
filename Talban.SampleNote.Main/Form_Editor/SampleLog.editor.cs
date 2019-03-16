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
    class SampleLog_FormEditor
    {
        // Listing of Variables
        // Constructing Classes for Utilities and Form Designers
        Utility.ConfigUtility designer = new Utility.ConfigUtility(@"./config/usercontrol.designer.config");
        Utility.StringParserUtility strParser = new Utility.StringParserUtility();
        Utility.TweenUtility Tween = new Utility.TweenUtility();
        Modules.History history;
        Modules.API remoteAPI;
        List<Color> color_variant = new List<Color>();
        List<Color> test_colors = new List<Color>();
        Dictionary<string, int> columnPositions;
        // Construct controls instances
        Panel panel_contents;
        ContextMenu testMenu;
        ToolTip dataExpansionTooltip;
        TextBox lastInitialsBox = null;
        // Initialize variables
        int last_displayedLogIndex = 0;
        int max_logsDisplayable = 17;
        int log_index = 0;
        int panel_height;
        
        // Prepare the form editor class variables
        public SampleLog_FormEditor(Panel panel_contents, Modules.API remoteAPI, Dictionary<string, int> columnPositions, ToolTip dataExpansionTooltip)
        {
            Console.WriteLine("Constructed SampleLog Editor");
            this.columnPositions = columnPositions;
            this.remoteAPI = remoteAPI;
            this.panel_contents = panel_contents;
            this.panel_contents.Controls.Clear();
            this.panel_contents.Parent.SizeChanged += Panel_contents_SizeChanged;
            this.history = new Modules.History();

            this.dataExpansionTooltip = dataExpansionTooltip;
            this.color_variant.Add(
                strParser.parseColor(designer["log_color.variant1"]));
            this.color_variant.Add(
                strParser.parseColor(designer["log_color.variant2"]));
            this.test_colors.Add(
                strParser.parseColor(designer["test_color.idle"]));
            this.test_colors.Add(
               strParser.parseColor(designer["test_color.started"]));
            this.test_colors.Add(
               strParser.parseColor(designer["test_color.finished"]));

            // Fill Log with forms
            log_index = remoteAPI.get_logcount();

            int logsDisplayed = 0;
            for (int index = 1; index <= log_index; index++)
            {
                if (logsDisplayed == max_logsDisplayable)
                {
                    break;
                }

                if (!remoteAPI.get_logdone(index))
                {
                    createLog(index);
                    logsDisplayed++;
                    last_displayedLogIndex = index;
                }
            }
            
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
        private void Panel_contents_SizeChanged(object sender, EventArgs e)
        {
            foreach (Panel pan in panel_contents.Controls)
            {
                pan.Width = panel_contents.Width;
                if (pan.Controls.ContainsKey("Tests_Panel"))
                {
                    FlowLayoutPanel testPanel = pan.Controls.Find("Tests_Panel", false)[0] as FlowLayoutPanel;
                    testPanel.Size = new Size(panel_contents.Width - columnPositions["Tests Required"], panel_height);
                    testPanel.Location = new Point(columnPositions["Tests Required"], testPanel.Location.Y);
                }

            }
        }
        // Recolors all the logs that are in the sample log container based on index
        private void recolorPattern()
        {
            for (int panel_index = 0; panel_index < panel_contents.Controls.Count; panel_index++)
            {
                panel_contents.Controls[panel_index].BackColor = this.color_variant[(panel_index + 1) % 2];
            }
        }
        // Creates a log using data from the log index
        public void createLog(int log_index)
        {
            //Console.WriteLine("Constructing Log");
            panel_height = Int32.Parse(designer["panel.height"]);
            Dictionary<string, string[]> logData = remoteAPI.fetch_log(log_index);
            int yPosition = 22;

            Panel logPanel = new Panel();
            logPanel.Name = string.Format("Log. {0}", log_index);
            logPanel.BackColor = this.color_variant[(panel_contents.Controls.Count+1) % 2];
            logPanel.ForeColor = Color.White;
            logPanel.Margin = new Padding(0, 0, 0, 0);
            logPanel.Height = panel_height;
            logPanel.Width = panel_contents.Width;

            FlowLayoutPanel testsPanel = new FlowLayoutPanel();
            testsPanel.Name = "Tests_Panel";
            testsPanel.FlowDirection = FlowDirection.LeftToRight;
            testsPanel.Anchor = AnchorStyles.Right & AnchorStyles.Left;
            testsPanel.WrapContents = false;
            testsPanel.AutoScroll = true;
            testsPanel.Tag = "Tests Required";
            //testsPanel.Dock = DockStyle.Right;
            testsPanel.Location = new Point(columnPositions["Tests Required"], yPosition-5); //yPosition-10
            testsPanel.Size = new Size(panel_contents.Width - columnPositions["Tests Required"], panel_height-yPosition);

            Label sampleNumber = new Label();
            sampleNumber.Text = logData["Sample Number"][0];
            sampleNumber.ForeColor = Color.White;
            sampleNumber.Location = new Point(columnPositions["Sample Number"], yPosition);
            sampleNumber.Font = new Font(sampleNumber.Font.Name, (float)14.25);
            sampleNumber.Tag = "Sample Number";

            Label projectNumber = new Label();
            projectNumber.Text = logData["Project Number"][0];
            projectNumber.ForeColor = Color.White;
            projectNumber.Location = new Point(columnPositions["Project Number"], yPosition);
            projectNumber.Tag = "Project Number";

            Label projectName = new Label();
            projectName.Text = logData["Project Name"][0];
            projectName.ForeColor = Color.White;
            projectName.Location = new Point(columnPositions["Project Name"], yPosition);
            projectName.Tag = "Project Name";

            Label clientName = new Label();
            clientName.Text = logData["Client Name"][0];
            clientName.ForeColor = Color.White;
            clientName.Location = new Point(columnPositions["Client Name"], yPosition);
            clientName.Tag = "Client Name";

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
            

            Label sampleDescription = new Label();
            sampleDescription.Text = logData["Samp. Description"][0];
            sampleDescription.ForeColor = Color.White;
            sampleDescription.Location = new Point(columnPositions["Samp. Description"], yPosition);
            sampleDescription.Tag = "Samp. Description";

            int prevRight = 0;
            foreach (string testName in logData["Tests Required"])
            {
                if (String.IsNullOrEmpty(testName))
                {
                    break;
                }
                Button testButton = new Button();
                testButton.AutoSize = true;
                testButton.Anchor = AnchorStyles.Left;
                testButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                testButton.FlatStyle = FlatStyle.Flat;
                testButton.FlatAppearance.BorderSize = 0;
                testButton.FlatAppearance.BorderColor = logPanel.BackColor;
                testButton.Text = testName.Substring(1);
                testButton.ForeColor = Color.White;
                testButton.ContextMenu = testMenu;
                color_testButton(testButton, Int16.Parse(testName.Substring(0, 1)));
                //testRequired.Location = new Point(prevRight, yPosition-4);
                testButton.TextAlign = ContentAlignment.MiddleLeft;
                testButton.Height = 30;
                
                prevRight = testButton.Location.X + testButton.Width + 3;
                testButton.MouseDown += TestButton_MouseClick;
                testsPanel.Controls.Add(testButton);
            }


            // Add all the sub columns to log panel
            logPanel.Controls.Add(sampleNumber);
            logPanel.Controls.Add(projectNumber);
            logPanel.Controls.Add(projectName);
            logPanel.Controls.Add(clientName);
            logPanel.Controls.Add(dateRecieved);
            logPanel.Controls.Add(sampleDescription);
            logPanel.Controls.Add(testsPanel);
            panel_contents.Controls.Add(logPanel);
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

            history.write("yeet", "yeet");
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
        private void color_testButton(Button testButton, int new_testStatus)
        {
            // Console.WriteLine("Writing Test Index: " + (new_testStatus - 1).ToString());
            testButton.ForeColor = test_colors[new_testStatus - 1];
        }
        // Runs a tween and a recolor to indicate test completion, then remove log and add a new one
        private void hide_log(Panel log, bool complete=false)
        {
            if (complete)
            {
                Console.WriteLine("Log has been completed. Hiding it");
                log.BackColor = Color.FromArgb(255, 131, 255, 94);
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
                    Tween.TweenSize(log, new Point(log.Width, 0), 1, 10);
                    timer.Enabled = false;
                    log.Dispose();
                    timer.Dispose();
                    recolorPattern();
                    log_index = remoteAPI.get_logcount();
                };

                last_displayedLogIndex++;

                // Display the next available log.  
                for (int index = last_displayedLogIndex; index < log_index; index++)
                {
                    if (!remoteAPI.get_logdone(last_displayedLogIndex))
                    {
                        createLog(index);
                        last_displayedLogIndex++;
                        last_displayedLogIndex = index;
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
                    }
                    else
                    {
                        color_testButton(testButton, new_teststatus);
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
