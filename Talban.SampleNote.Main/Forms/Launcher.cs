using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

// For Loading API DLL's at Runtime
using System.Reflection;

namespace SampleNote.Main.Forms
{
    public partial class Launcher : Form
    {
        Dictionary<string, string[]> API_List = new Dictionary<string, string[]>();
        List<string> recentFiles = new List<string>();
        Utility.TweenUtility Tween = new Utility.TweenUtility();
        Modules.API remoteAPI = new Modules.API();
        string selectedAPIKey = null;
        string selectedOption;
        bool processingFile = false;

        string xml_apis = @"./background/api.available.xml";

        public Launcher()
        {
            InitializeComponent();

            new Utility.HeaderUtility(Form_Header);
            new Utility.TooltipUtility(ToolTip);

            // Add APIs to drop down
            XmlReader xmlReader = XmlReader.Create(xml_apis);
            while (xmlReader.Read())
            {
                Console.WriteLine(xmlReader.Value);
                // Check if is parent node
                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.HasAttributes)
                {
                    string api_name = xmlReader.GetAttribute("name").ToString();
                    string api_ext = "";
                    Console.WriteLine(String.Format("Try: {0}", api_name));

                    XmlReader subReader = xmlReader.ReadSubtree();
                    while (subReader.Read())
                    {
                        // Read the sub classes of the root
                        switch (subReader.Name)
                        {
                            case "extensions":
                                api_ext = subReader.ReadElementContentAsString();
                                break;
                                
                            case "module":
                                string module_value = subReader.ReadElementContentAsString();
                                Console.WriteLine(String.Format("Fetching: {0}", module_value));
                                if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"Lib/", module_value)))
                                {
                                    Console.WriteLine("DLL Module Exists");
                                    // Insert new element to List
                                    Console.WriteLine(api_name);
                                    API_List.Add(api_name, new string[2] { module_value, api_ext });
                                }
                                break;
                        }
                    }
                }
            }
            xmlReader.Dispose();

            listbox_recentFiles.Items.Clear();
            listbox_recentFiles.Items.Add("None");

            panel_loadscreen.Visible = false;
            panel_loadscreen.Size = new Size(776, 376);

            foreach (string path in File.ReadAllLines(@"./recent/recent.log.dat"))
            {
                if (File.Exists(path) && !recentFiles.Contains(path))
                {
                    recentFiles.Add(path);
                }
            }

            foreach (string path in recentFiles)
            {
                listbox_recentFiles.Items.Add(Path.GetFileName(path));
            }

            File.WriteAllLines(@"./recent/recent.log.dat", recentFiles);
            // Add API key names to the Drop Down Box on Launcher
            foreach (string apiKeyName in API_List.Keys)
            {
                dropdown_selectedApi.Items.Add(apiKeyName);
            }

            selectAPI(dropdown_selectedApi.Items[0].ToString());
            dropdown_selectedApi.Text = selectedAPIKey;

            // Form Fader
            Opacity = 0;
            Timer opacity_timer = new Timer();
            opacity_timer.Enabled = true;
            opacity_timer.Interval = 30;
            opacity_timer.Tick += (s, e) =>
            {
                this.Opacity += .1;
                if (this.Opacity >= 1)
                {
                    this.Opacity = 1;
                    opacity_timer.Enabled = false;
                    opacity_timer.Dispose();
                }
            };
        }

        private void selectAPI(string api_name)
        {
            selectedAPIKey = api_name;
            Console.WriteLine(API_List[api_name][0]);
            label_dataheader.Text = string.Format("{0} File Data", api_name.Replace(" API", ""));
            dialog_newFile.Filter = API_List[api_name][1];
            dialog_openFile.Filter = API_List[api_name][1];
        }

        private void button_newfile_Click(object sender, EventArgs e)
        {
            if (dialog_newFile.ShowDialog() == DialogResult.OK)
            {
                // Check if the file already exists
                if (File.Exists(dialog_newFile.FileName))
                {
                    MessageBox.Show(
                        "The file already exists!",
                        "File Name Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
                selectedOption = "create";
                prompt_data(dialog_newFile.FileName);
            }
        }

        private void prompt_data(string fileName)
        {
            label_filepath.Text = fileName;
            label_filename.Text = Path.GetFileName(fileName);
            ToolTip.SetToolTip(label_filename, Path.GetFileName(fileName));
            if (File.Exists(fileName))
            {
                FileInfo f = new FileInfo(fileName);
                label_filesize.Text = (f.Length / 1024).ToString() + "kb";
            }
            Tween.TweenSize(panel_projectdata, new Point(0, panel_projectdata.Height), 1, 10);
        }

        private void button_loadfile_Click(object sender, EventArgs e)
        {
            if (dialog_openFile.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(dialog_openFile.FileName))
                {
                    MessageBox.Show(
                        "The file does not exist!",
                        "File Path Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                selectedOption = "access";
                prompt_data(dialog_openFile.FileName);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Tween.TweenSize(panel_projectdata, new Point(panel_filedata.Width, panel_projectdata.Height), 1, 10);
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            // Check to see if a password has been entered
            if (input_password.Text == "Enter Password" || String.IsNullOrEmpty(input_password.Text))
            {
                MessageBox.Show("Enter a proper password.", "Password Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            panel_loadscreen.Visible = true;

            remoteAPI.Set_API(selectedAPIKey);

            Console.WriteLine("Sumitting New File");
            Console.WriteLine("Registering: " + label_filepath.Text);

            if (selectedOption == "create")
            {
                remoteAPI.create_file(label_filepath.Text, input_password.Text);
            }
            else if (selectedOption == "access")
            {
                string access_file_state = remoteAPI.access_file(label_filepath.Text, input_password.Text);
                if (access_file_state != "success")
                {
                    panel_loadscreen.Visible = false;
                    displayPrompt("denied");
                    MessageBox.Show(access_file_state, "Access Problem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    reset_ddrop();
                    return;
                }

            }

            displayPrompt("access");
            addPathToRecent(label_filepath.Text);
            displayPrompt("reading_log");

            new Forms.User_Control(remoteAPI);
            this.Hide();
        }

        private void input_password_Click(object sender, EventArgs e)
        {
            if (input_password.Text == "Enter Password")
            {
                input_password.Text = "";
                input_password.UseSystemPasswordChar = true;
            }
        }

        private void checkbox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            input_password.UseSystemPasswordChar = !checkbox_showpassword.Checked;
        }

        private void Launcher_DragEnter(object sender, DragEventArgs e)
        {
            int increment = 1;

            Timer timer = new Timer();
            timer.Interval = 20;
            picturebox_upload.Location = new Point(picturebox_upload.Location.X, 95);
            timer.Tick += (s, _) =>
            {
                picturebox_upload.Location = new Point(picturebox_upload.Location.X, 95 + increment);
                if (increment >= 5)
                {
                    increment = 5;
                    picturebox_upload.Location = new Point(picturebox_upload.Location.X, 95 + increment);
                    timer.Enabled = false;
                    timer.Dispose();
                }
                increment++;
            };

            panel_dragdropoutside.Visible = true;
            panel_dragdropoutside.Size = new Size(776, 373);
            picturebox_upload.Image = Properties.Resources.Upload_Graphic;

            timer.Enabled = true;

            if (e.Data.GetDataPresent(DataFormats.FileDrop) && !processingFile)
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void Launcher_DragLeave(object sender, EventArgs e)
        {
            picturebox_upload.Location = new Point(picturebox_upload.Location.X, 95);
            panel_dragdropoutside.Visible = false;
        }

        private void reset_ddrop()
        {
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1500;
            timer.Tick += (s, _) =>
            {
                displayPrompt("upload");

                processingFile = false;
                timer.Enabled = false;
                timer.Dispose();
            };
        }

        private void displayPrompt(string type)
        {
            panel_dragdropoutside.Visible = true;
            if (type == "upload")
            {
                panel_dragdropoutside.Visible = false;
                panel_dragdropprompt.BackColor = Color.FromArgb(255, 25, 25, 25);
                label_ddafilehere.Text = "Drag and Drop a file here";
                label_ddafilehere.ForeColor = Color.FromArgb(255, 200, 200, 200);
                picturebox_upload.Image = Properties.Resources.Upload_Graphic;
            }
            else if (type == "denied")
            {
                picturebox_upload.Image = Properties.Resources.Denied_File;
                panel_dragdropprompt.BackColor = Color.FromArgb(255, 50, 0, 0);
                label_ddafilehere.Text = "File Denied!";
                label_ddafilehere.ForeColor = Color.FromArgb(255, 255, 0, 0);
            }
            else if (type == "access")
            {
                picturebox_upload.Image = Properties.Resources.Accessing_File;
                panel_dragdropprompt.BackColor = Color.FromArgb(255, 192, 255, 192);
                label_ddafilehere.Text = "Accessing File!";
                label_ddafilehere.ForeColor = Color.FromArgb(255, 57, 181, 74);
            }
            else if (type == "reading_log")
            {
                picturebox_loading.Image = Properties.Resources.Reading_Logs;
                label_loading.Text = "Reading Logs...";
            }
        }

        private void Launcher_DragDrop(object sender, DragEventArgs e)
        {
            processingFile = true;
            Console.WriteLine("Recieved File Drop");
            //panel_dragdropoutside.Visible = false;
            label_ddafilehere.Text = "Verifying File...";
            picturebox_upload.Image = Properties.Resources.Verifying_File;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 1)
            {
                displayPrompt("denied");
                Console.WriteLine("Only one file may be dropped");
                MessageBox.Show("Too many files have been dropped.", "Drop Count Exceeded",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset_ddrop();
                return;
            }
            try
            {
                string fileType = "None";
                string selectedFile = "";
                foreach (string file in files)
                {
                    foreach (string key in API_List.Keys)
                    {
                        string extension_filter = API_List[key][1];
                        // *.ext so substr[1]
                        if (extension_filter.Contains(Path.GetExtension(file)))
                        {
                            fileType = key.Replace(".dll", string.Empty);
                            selectedFile = file;
                            Console.WriteLine("Drop Selected Key:" + fileType);
                        }
                    }
                }

                if (fileType == "None")
                {
                    displayPrompt("denied");
                }
                else
                {
                    displayPrompt("access");
                    selectedOption = "access";
                    prompt_data(selectedFile);
                    selectAPI(fileType);
                }
                reset_ddrop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }



        }

        private void addPathToRecent(string path)
        {
            if (recentFiles.Contains(path))
            {
                return;
            }

            File.AppendAllText(@"./recent/recent.log.dat",

                String.Format("{0}{1}",
                    path,
                    Environment.NewLine));

        }

        private void listbox_recentFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listbox_recentFiles.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {

                string filename = listbox_recentFiles.Items[index].ToString();
                if (filename == "None")
                {
                    return;
                }
                foreach (string pathString in File.ReadAllLines(@"./recent/recent.log.dat"))
                {
                    if (pathString.Contains(filename))
                    {
                        Console.WriteLine(String.Format("Fetching: {0}", pathString));
                        selectedOption = "access";
                        prompt_data(pathString);
                    }
                }
            }
        }

        private void button_exitform_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dropdown_selectedApi_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectAPI(dropdown_selectedApi.Text);
        }
    }
}
