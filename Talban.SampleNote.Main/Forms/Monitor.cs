using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleNote.Main.Forms
{
    public partial class Monitor : Form
    {
        Utility.ConfigUtility designer = new Utility.ConfigUtility(@"./config/usercontrol.designer.config");
        Modules.API remoteAPI;
        Dictionary<string, int> columnPositions = new Dictionary<string, int>();
        int panel_height;

        public Monitor(Modules.API remoteAPI, Dictionary<string, int> columnPositions)
        {
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header, sizable: true, canHideHeader: true);
            this.remoteAPI = remoteAPI;
            this.columnPositions = columnPositions;
            // Create a timer that adjusts the label of the clock.
            Timer timer_clock = new Timer();
            timer_clock.Enabled = true;
            timer_clock.Interval = 1000;
            timer_clock.Tick += (s, e) =>
            {
                label_clock.Text = DateTime.Now.ToString("F");
            };

            panel_height = Int32.Parse(designer["panel.height"]);
            panel_contents.SizeChanged += Panel_contents_SizeChanged;
        }

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


        private void button_exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
