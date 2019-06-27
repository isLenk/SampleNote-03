using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace SampleNote.Main.Modals
{
    public partial class History_Reader : Form
    {
        Regex data_parser = new Regex("[^|]+");
        string history_path = @"./background/test.log.dat"; // Path.Combine(Environment.CurrentDirectory, @" / background/test.log.dat");
        public History_Reader()
        {
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header);
            // Remove all controls from the log before adding new ones in
            panel_logs.Controls.Clear();
            // Check if the history file has been removed/moved. Make a new one
            if (!File.Exists(history_path))
            {
                File.Create(history_path);
            }

            // Read all the lines, and parse them
            foreach (string line in File.ReadAllLines(history_path))
            {
                make_log(parse_log(line));
            }

            this.ShowDialog();
        }

        private void button_exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Dictionary<string, string> parse_log(string log_line)
        {
            MatchCollection data = data_parser.Matches(log_line);
            Dictionary<string, string> log_data = new Dictionary<string, string>();
            try
            {
                log_data.Add("date", data[0].Value);
                log_data.Add("sample number", data[1].Value);
                log_data.Add("mod", data[2].Value);
            }
            catch
            {
                Console.WriteLine("Couldn't parse log data successfully.");
                log_data.Clear();
                log_data.Add("date", "NULL");
                log_data.Add("sample number", "NULL");
                log_data.Add("mod", "NULL");
            }
            return log_data;
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
            date_label.ForeColor = Color.White;
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
            mod_label.ForeColor = Color.White;
            mod_label.Padding = new Padding(5, 0, 0, 0);
            mod_label.Text = log_data["mod"];

            log_panel.Controls.Add(mod_label);
            log_panel.Controls.Add(samplenum_label);
            log_panel.Controls.Add(date_label);
            panel_logs.Controls.Add(log_panel);
        }
    }
}
