using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SampleNote.Main.Modals
{
    public partial class Text_Editor : Form
    {
        string file_path;
        List<string> file_data = new List<string>();

        public Text_Editor(string file_path)
        {
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header);
            this.file_path = file_path;
            
            // Parse the lines of text
            foreach (string line in File.ReadAllLines(file_path))
            {
                file_data.Add(line);
            }

            file_data.ForEach(s =>
            {
                textbox_textdata.Text += String.Format("{0}{1}", s, Environment.NewLine);
            });

            label_filepath.Text = Path.GetFileName(file_path);

            textbox_textdata.DragEnter += Textbox_textdata_DragEnter;
            textbox_textdata.DragDrop += Textbox_textdata_DragDrop;
            textbox_textdata.AllowDrop = true;
        }

        private void Textbox_textdata_DragDrop(object sender, DragEventArgs e)
        {
            
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 1)
            {
                Console.WriteLine("Only one file may be dropped");
                MessageBox.Show("Too many files have been dropped.", "Drop Count Exceeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                textbox_textdata.Text = File.ReadAllText(files[0]);
                file_path = files[0];
            }
            catch
            {
                MessageBox.Show("Unable to parse file.", "Parse Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void Textbox_textdata_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("HEY");
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textbox_textdata.Text = "";
            file_data.ForEach(s =>
            {
                textbox_textdata.Text += String.Format("{0}{1}", s, Environment.NewLine);
            });
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("Confirm Save Changes?", 
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgResult == DialogResult.No)
            {
                return;
            }

            if (checkbox_backup.Checked)
            {
                string bakpack_path = String.Format("{0}/bakpack/list.tests/", Environment.CurrentDirectory);
                string file_name = Path.GetFileName(file_path);
                int fileCountInBakpack = Directory.GetFiles(bakpack_path).Length;
                // Save the backup
                File.Copy(
                    file_path,
                    Path.Combine(bakpack_path, String.Format("{0}_{1}.bak", fileCountInBakpack, file_name)));
            }

            try
            {
                File.WriteAllText(file_path, textbox_textdata.Text);
            }
            catch
            {
                MessageBox.Show("Could not write to file.", "Write Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
