using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleNote.Main.Modals
{
    public partial class History_Reader : Form
    {
        public History_Reader()
        {
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header);
            
            this.ShowDialog();
        }

        private void button_exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Console.WriteLine(DateTime.Now.ToString("F"));
        private void make_log(Dictionary<string, string> log_data)
        {

            Panel log_panel = new Panel();
            Label date_label = new Label();
            Label samplenum_label = new Label();
            Label mod_label = new Label();

            log_panel.BackColor = Color.FromArgb(255, 50, 50, 50);
            log_panel.Height = 32;
            log_panel.Width = panel_logs.Width;

            // Date Label
            date_label.Dock = DockStyle.Left;
            date_label.AutoSize = false;
            date_label.TextAlign = ContentAlignment.MiddleLeft;
            date_label.Padding = new Padding(5, 0, 0, 0);
            date_label.Width = 192;
            date_label.Text = log_data["date"];
            // Sample Number Label
            samplenum_label.Dock = DockStyle.Left;
            samplenum_label.AutoSize = false;
            samplenum_label.ForeColor = Color.FromArgb(255, 1, 118, 191);
            samplenum_label.Width = 85;
            samplenum_label.TextAlign = ContentAlignment.MiddleRight;
            samplenum_label.Text = log_data["sample number"];
            // Modification Label
            mod_label.Dock = DockStyle.Fill;
            mod_label.AutoSize = false;
            mod_label.Width = 494;
            mod_label.TextAlign = ContentAlignment.MiddleLeft;
            mod_label.Padding = new Padding(5, 0, 0, 0);
            mod_label.Text = log_data["mod"];

            log_panel.Controls.Add(date_label);
            log_panel.Controls.Add(samplenum_label);
            log_panel.Controls.Add(mod_label);
            panel_logs.Controls.Add(log_panel);
        }
    }
}
