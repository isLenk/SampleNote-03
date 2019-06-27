using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SampleNote.Main.Form_Editor
{
    public abstract class GeneralFormArchitect : Interface.IFormArchitect
    {
        public Utility.ConfigUtility configurationDesigner = new Utility.ConfigUtility(Path.Combine(Environment.CurrentDirectory, "config/usercontrol.designer.config"));
        public Utility.TweenUtility tweenUtility = new Utility.TweenUtility();
        Modules.DYMOLabelWriter dymoLabelWriter = new Modules.DYMOLabelWriter();
        public Modules.History history;

        public List<Color> colorVariant = new List<Color>(), testColor = new List<Color>();
        public Dictionary<string, int> columnPosition;

        public Modules.API remoteApi { get; set; }
        public Panel panelContents;
        public ToolTip dataExpansionTooltip;

        public static int previousLogIndex;
        public int logIndex;
        public const int displayableLogsCount = 17;
        float fontSize = 12f;
        int panelHeight;
        public bool isMonitor = false, setup = false;
        
        public Panel CreateLog(int logIndex, bool printLabel = false)
        {
            panelHeight = Int32.Parse(configurationDesigner["panel.height"]);
            Dictionary<string, string[]> logData = remoteApi.fetch_log(logIndex);
            int yPosition = 22;

            Panel logPanel = new Panel();
            logPanel.Name = logIndex.ToString();
            logPanel.BackColor = this.colorVariant[(panelContents.Controls.Count + 1) % 2];
            logPanel.ForeColor = Color.White;
            logPanel.Font = new Font("Trebuchet Ms", fontSize);
            logPanel.Margin = new Padding(0, 0, 0, 0);
            logPanel.Height = panelHeight;
            logPanel.Width = panelContents.Width;

            FlowLayoutPanel testsPanel = new FlowLayoutPanel();
            testsPanel.Name = string.Format("Log Panel. {0}", logIndex);
            testsPanel.FlowDirection = FlowDirection.LeftToRight;
            testsPanel.Anchor = AnchorStyles.Right & AnchorStyles.Left;
            testsPanel.WrapContents = false;
            testsPanel.AutoScroll = true;
            testsPanel.Tag = "Tests Required";
            testsPanel.Location = new Point(columnPosition["Tests Required"], yPosition - 5);
            testsPanel.Size = new Size(panelContents.Width - columnPosition["Tests Required"], panelHeight - yPosition);

            Label sampleNumber = new Label();
            sampleNumber.Name = "Sample Number";
            sampleNumber.Text = logData["Sample Number"][0];
            sampleNumber.ForeColor = Color.White;
            sampleNumber.Location = new Point(columnPosition["Sample Number"], yPosition);
            sampleNumber.Font = new Font(sampleNumber.Font.Name, (float)14.25);
            sampleNumber.Tag = "Sample Number";
            sampleNumber.AutoSize = false;
            sampleNumber.Width = columnPosition["Project Number"] - sampleNumber.Left;

            Label projectNumber = new Label();
            projectNumber.Text = logData["Project Number"][0];
            projectNumber.ForeColor = Color.White;
            projectNumber.Location = new Point(columnPosition["Project Number"], yPosition);

            projectNumber.Tag = "Project Number";
            projectNumber.AutoSize = false;
            projectNumber.Width = columnPosition["Project Name"] - projectNumber.Left;

            Label projectName = new Label();
            projectName.Text = logData["Project Name"][0];
            projectName.ForeColor = Color.White;
            projectName.Location = new Point(columnPosition["Project Name"], yPosition);
            projectName.Tag = "Project Name";
            projectName.AutoSize = false;
            projectName.Width = columnPosition["Client Name"] - projectName.Left;

            Label clientName = new Label();
            clientName.Text = logData["Client Name"][0];
            clientName.ForeColor = Color.White;
            clientName.Location = new Point(columnPosition["Client Name"], yPosition);
            clientName.Tag = "Client Name";
            clientName.AutoSize = false;
            clientName.Width = columnPosition["Date Recieved"] - clientName.Left;

            Label dateRecieved = new Label();
            dateRecieved.Text = logData["Date Recieved"][0];
            dateRecieved.ForeColor = Color.White;
            dateRecieved.Location = new Point(columnPosition["Date Recieved"], yPosition);
            dateRecieved.Tag = "Date Recieved";

            DateTime timePlaceholder;
            if (DateTime.TryParse(logData["Date Recieved"][0], out timePlaceholder))
            {
                dataExpansionTooltip.SetToolTip(dateRecieved, (timePlaceholder.ToString("hh:mmtt")));
            }
            dateRecieved.AutoSize = false;
            dateRecieved.Width = columnPosition["Samp. Description"] - dateRecieved.Left;

            Label sampleDescription = new Label();
            sampleDescription.Text = logData["Samp. Description"][0];
            sampleDescription.ForeColor = Color.White;
            sampleDescription.Location = new Point(columnPosition["Samp. Description"], yPosition);
            sampleDescription.Tag = "Samp. Description";
            sampleDescription.AutoSize = false;
            sampleDescription.Width = columnPosition["Samp. Location"] - sampleDescription.Left;

            Label sampleLocation = new Label();
            sampleLocation.Text = logData["Samp. Location"][0];
            sampleLocation.ForeColor = Color.White;
            sampleLocation.Location = new Point(columnPosition["Samp. Location"], yPosition);
            sampleLocation.Tag = "Samp. Location";
            sampleLocation.AutoSize = false;
            sampleLocation.Width = columnPosition["Tests Required"] - sampleLocation.Left;
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
                    testButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    testButton.FlatAppearance.BorderSize = 0;
                    testButton.FlatAppearance.BorderColor = logPanel.BackColor;
                }

                testButton.AutoSize = true;
                testButton.Anchor = AnchorStyles.Left;
                testButton.FlatStyle = FlatStyle.Flat;
                testButton.Text = testName.Substring(1);
                testButton.ForeColor = Color.White;
                SetTestObjectColor(testButton, Int16.Parse(testName.Substring(0, 1)));
                testButton.TextAlign = ContentAlignment.MiddleLeft;
                testButton.Height = 30;

                prevRight = testButton.Location.X + testButton.Width + 3;
                testsPanel.Controls.Add(testButton);


            }

            // Print the Label if the argument allows it
            if (printLabel)
            {
                // Pass the log data dictionary to the function
                dymoLabelWriter.PrintLabel(logData);
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
            return logPanel;
        }

       

        public void ListSizePropertyChanged()
        {
            foreach (Panel panelObject in panelContents.Controls)
            {
                panelObject.Width = panelContents.Width;

                FlowLayoutPanel testPanel = panelObject.Controls.Find($"Log Panel. {panelObject.Name}", false)[0] as FlowLayoutPanel;
                testPanel.Size = new Size(panelContents.Width - columnPosition["Tests Required"], panelHeight);
                testPanel.Location = new Point(columnPosition["Tests Required"], testPanel.Location.Y);
            }
        }

        public void ApplyListColorPattern()
        {
            // var assigned to panels index and assign it to a color based on a math equation
           for (int panelIndex = 0; panelIndex < panelContents.Controls.Count; panelIndex++)
           {
                panelContents.Controls[panelIndex].BackColor = colorVariant[(panelIndex + 1) % 2];
           }
        }

        public void RemoveLog(Panel panelLogObject)
        {
            HideLogObject(panelLogObject, logCompleted: true, overrideColor: Color.FromArgb(170, 0, 0));
        }

        public abstract void SetTestObjectColor(Control testObject, int newTestStatus);        

        public void HideLogObject(Panel logObject, bool logCompleted = false, Color? overrideColor = null)
        {
            if (logCompleted)
            {
                Console.WriteLine("Log has been completed: Hiding Object");
                // If object is null then set it to Green
                logObject.BackColor = overrideColor.GetValueOrDefault(Color.FromArgb(255, 131, 255, 94));

                Color grayedOutColor = Color.FromArgb(40, 40, 40);
                // Disable and set fore color to a dark gray
                foreach (Control control in logObject.Controls)
                {
                    control.ForeColor = grayedOutColor;
                    if (control.HasChildren)
                    {
                        foreach (Control subControl in control.Controls)
                        {
                            subControl.ForeColor = grayedOutColor;
                            subControl.Enabled = false;
                        }
                    }
                }

                Timer timer = new Timer();
                timer.Enabled = true;
                timer.Interval = 1500;
                timer.Tick += (s, e) =>
                {
                    tweenUtility.TweenSize(logObject, new Point(logObject.Width, 0), 1, 10);
                    timer.Enabled = false;
                    logObject.Dispose();
                    timer.Dispose();
                    ApplyListColorPattern();
                    logIndex = remoteApi.get_logcount();
                };

                previousLogIndex++;

                // Display the next available log.  
                for (int index = previousLogIndex; index < logIndex; index++)
                {
                    if (!remoteApi.get_logdone(previousLogIndex))
                    {
                        CreateLog(index);
                        previousLogIndex = index;
                        break;
                    }
                }

            }
        }
    }
}
