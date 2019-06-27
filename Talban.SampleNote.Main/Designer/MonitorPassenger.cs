using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SampleNote.Main.Designer
{
    public class MonitorPassenger : Form_Editor.GeneralFormArchitect
    {
        Utility.StringParserUtility stringParser = new Utility.StringParserUtility();

        public MonitorPassenger(Panel panelContents, Modules.API remoteApi, Dictionary<string, int> columnPosition, ToolTip dataExpansionTooltip)
        {
            this.panelContents = panelContents;
            this.remoteApi = remoteApi;
            this.dataExpansionTooltip = dataExpansionTooltip;
            this.columnPosition = columnPosition;
            this.logIndex = this.remoteApi.get_logcount();
            this.isMonitor = true;
            this.panelContents.Controls.Clear();

            this.panelContents.Parent.SizeChanged += (s, e) => { this.ListSizePropertyChanged(); };

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
                    logsDisplayed++;
                    previousLogIndex = index;
                }
            }

            setup = false;
        }

        // A gate that changes the arguments to suit the HideLogObject method
        public void PassHideLogObject(string logObjectName, bool logCompleted = false, Color? overrideColor = null)
        {
            Console.WriteLine("Recieved Pass For Object: " + logObjectName);
            Panel logObject = (Panel)panelContents.Controls.Find(logObjectName, false)[0];
            HideLogObject(logObject, logCompleted, overrideColor);
        }

        public override void SetTestObjectColor(Control testObject, int newTestStatus)
        {
            Console.WriteLine($"There are {testColor.Count} different colors and Desired Test Status: {newTestStatus}");
            testObject.ForeColor = testColor[newTestStatus - 1];
        }

        public void PassTestObjectColor(string panelName, string testText, int newTestStatus)
        {
            Panel logPanel = (Panel)panelContents.Controls.Find(panelName, false)[0];
            FlowLayoutPanel testPanel = (FlowLayoutPanel)logPanel.Controls.Find($"Log Panel. {panelName}", false)[0];
            foreach (Control subTestObject in testPanel.Controls)
            {
                // Console.WriteLine($"Comparing {subTestObject.Text} to {testText}");
                if (subTestObject.Text == testText)
                {
                    SetTestObjectColor(subTestObject, newTestStatus);
                    return;
                }
            }
        }
    }
}
