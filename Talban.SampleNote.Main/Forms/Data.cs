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
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace SampleNote.Main.Forms
{
    public partial class Data : Form
    {
        Dictionary<string, string> column_data;
        List<string> items = new List<string>();
        Modules.API remoteAPI;
        testlist_module testlist;
        User_Control userControl;
        Utility.UTILSQL_TestCode UTILSQL = new Utility.UTILSQL_TestCode();

        Bitmap image_locked = Properties.Resources.Locked;
        Bitmap image_unlocked = Properties.Resources.Unlocked;
        Modals.Text_Editor text_editor = null;
        
        public Data(Modules.API remoteAPI, User_Control userControl)
        {
            InitializeComponent();
            new SampleNote.Main.Utility.HeaderUtility(Form_Header);
            testlist = new testlist_module(listbox_testlist, textbox_filtersearch, label_itemcount, LABEL_LTestsRequiredList, items, UTILSQL);
            this.remoteAPI = remoteAPI;
            this.userControl = userControl;
            this.button_samplenumber.Text = remoteAPI.pull_samplenum();
            lock_fields.Click += fieldLockMethod;
            lock_fields1.Click += fieldLockMethod;
            this.column_data = remoteAPI.fetch_columndata(inverted:true);

            // Binding Handlers
            Binding binding_label_sampnumber = new Binding("Text", button_samplenumber, "Text",
                true, DataSourceUpdateMode.OnValidation);
            Binding binding_label_client = new Binding("Text", textbox_clientname, "Text",
                true, DataSourceUpdateMode.OnPropertyChanged);
            Binding binding_label_projnumber = new Binding("Text", textbox_projectnumber, "Text",
                true, DataSourceUpdateMode.OnPropertyChanged);
            Binding binding_label_projname = new Binding("Text", textbox_projectname, "Text",
                true, DataSourceUpdateMode.OnPropertyChanged);


            // Add the bindings to the labels.
            LABEL_LSampleNumber.DataBindings.Add(binding_label_sampnumber);
            LABEL_LClient.DataBindings.Add(binding_label_client);
            LABEL_LProjectNumber.DataBindings.Add(binding_label_projnumber);
            LABEL_LProjectName.DataBindings.Add(binding_label_projname);
            CHECKBOX_PrintLabel.Checked = new Modules.DYMOLabelWriter().checkAvailable();
        }
        
        private void fieldLockMethod(object sender, EventArgs e)
        {
            PictureBox fieldLock = sender as PictureBox;
            if (fieldLock.Image == image_locked)
            {
                fieldLock.Image = image_unlocked;
            }
            else
            {
                fieldLock.Image = image_locked;
            }
        }
        
        // Creating a seperate class for the test list module is unecessary but is quite more usable
        class testlist_module
        {
            //string testsFile = @"./config/test_list.dat";
            Utility.UTILSQL_TestCode UTILSQL;
            List<string[]> TestNames;
            ListBox listbox_testlist;
            TextBox textbox_filtersearch;
            Label label_itemcount;
            Label label_testList;
            List<string> items;
            
            public testlist_module(ListBox testList, TextBox filterSearch, Label itemCount, Label lbl_testList, List<string> items, Utility.UTILSQL_TestCode UTILSQL)
            {
                listbox_testlist = testList;
                textbox_filtersearch = filterSearch;
                label_itemcount = itemCount;
                label_testList = lbl_testList;
                this.UTILSQL = UTILSQL;
                // Add Test List to TestNames
                TestNames = UTILSQL.GetTestNames();

                this.items = items;
                listbox_testlist.SelectedIndexChanged += new System.EventHandler(test_selected);
                textbox_filtersearch.TextChanged += new System.EventHandler(testfilter_textchanged);

                readTests();
            }
            
            public void reset()
            {
                TestNames = UTILSQL.GetTestNames();
                items.Clear();
                listbox_testlist.ClearSelected();
                readTests();
            }

            private void readTests()
            {
                listbox_testlist.Items.Clear();
                //listbox_testlist.Items.AddRange(System.IO.File.ReadAllLines(testsFile));
                foreach (string[] test_data in TestNames)
                {
                    if (test_data.Length > 1)
                    {
                        listbox_testlist.Items.Add(test_data[1]);
                    }
                    else
                    {
                        listbox_testlist.Items.Add(test_data[0]);
                    }

                }
                // Will not work as its a string array now. listbox_testlist.Items.AddRange(TestNames.ToArray());
                reselect();
            }

            bool reselecting = false;
            private void reselect()
            {
                reselecting = true;
                foreach (string item in items)
                {
                    if (listbox_testlist.Items.Contains(item) && listbox_testlist.SelectedItems.Contains(item) == false)
                    {
                        listbox_testlist.SelectedItems.Add(item);
                    }
                }
                displayToTestList();
                label_itemcount.Text = string.Format("{0} Selected", items.Count.ToString());
                reselecting = false;
            }

            private void test_selected(object sender, EventArgs e)
            {
                if (reselecting) {
                    return;
                }
                for (int index = 0; index < listbox_testlist.Items.Count; index++)
                {
                    string item_name = listbox_testlist.Items[index].ToString();

                    // Add item to list if it has not yet been selected
                    if (items.Contains(item_name) && listbox_testlist.SelectedItems.Contains(item_name) == false)
                    {
                        items.Remove(item_name);
                    }

                    if (items.Count < 11)
                    {
                        if (items.Contains(item_name) == false && listbox_testlist.SelectedItems.Contains(item_name))
                        {
                            items.Add(item_name);
                        }
                    }
                    else
                    {
                        // Checks to see if the item list does not contain the thing yet it is selected.
                        if (items.Contains(item_name) == false && listbox_testlist.SelectedItems.Contains(item_name))
                        {
                            MessageBox.Show("Exceeded Test Selection Count");
                            listbox_testlist.SelectedItems.Remove(item_name);
                        }
                    }
                }

                displayToTestList();
                label_itemcount.Text = string.Format("{0} Selected", items.Count.ToString());
            }
            
            private void displayToTestList()
            {
                label_testList.Text = "";
                foreach (string selection in items)
                {
                    label_testList.Text += string.Format("- {0}{1}", selection, Environment.NewLine);
                }
            }
            private void filterString(string filterText)
            {
                List<string> filteredStrings = new List<string>();
                foreach (string[] line in TestNames)//File.ReadAllLines(testsFile))
                {
                    if (line[0].Contains(filterText))
                    {
                        filteredStrings.Add(line[0]);
                    }
                    else if (line.Length > 1 && line[1].Contains(filterText))
                    {
                        filteredStrings.Add(line[1]);
                    }
                }

                listbox_testlist.Items.Clear();
                filteredStrings.ForEach(s => listbox_testlist.Items.Add(s));

                reselect();
            }

            private void testfilter_textchanged(object sender, EventArgs e)
            {
                string filterData = textbox_filtersearch.Text;

                // If there is no filter text then return all of the test names
                if (String.IsNullOrEmpty(filterData))
                {
                    readTests();
                    return;
                }

                filterString(filterData);
            }
        }

        private bool checkData()
        {
            foreach (Object obj in this.Controls)
            {
                if (obj is Panel)
                {
                    Panel panel_obj = obj as Panel;
                    if (panel_obj.HasChildren)
                    {
                        foreach (Object child_object in panel_obj.Controls)
                        {
                            if (child_object is TextBox)
                            {
                                TextBox inputBox = child_object as TextBox;
                                if (String.IsNullOrEmpty(inputBox.Text))
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            if (items.Count == 0)
            {
                return false;
            }

            return true;
        }
        
        // Parse all field Data (Parameter for clearing all fields when read)
        private Dictionary<string, string> read_fieldData(bool ClearAfterRead=true)
        {
            Dictionary<string, string> field_data = new Dictionary<string, string>();

            field_data.Add(button_samplenumber.Tag.ToString(), button_samplenumber.Text);

            foreach (Object obj in this.Controls)
            {
                if (obj is Panel)
                {
                    Panel panel_object = obj as Panel;
                    if (panel_object.HasChildren)
                    {
                        foreach (Object childObject in panel_object.Controls)
                        {
                            if (childObject is TextBox)
                            {
                                TextBox textbox_field = childObject as TextBox;
                                if (!String.IsNullOrEmpty(textbox_field.Tag.ToString()))
                                {
                                    field_data.Add(textbox_field.Tag.ToString(), textbox_field.Text.ToString());
                                }
                            }
                        }
                    }
                }
            }

            string itemString = "";

            items.ToList().ForEach(s =>
            {
                itemString += String.Format("/{0}/", s);
            });

            // Date Recieved
            field_data.Add(dtp_date.Tag.ToString(), 
                String.Format("{0} {1}",
                dtp_date.Value.ToString(dtp_date.CustomFormat), 
                dtp_time.Value.ToString(dtp_time.CustomFormat)));
            // Test Required
            field_data.Add(listbox_testlist.Tag.ToString(), itemString);
            
            if (ClearAfterRead)
            {
                clear_fields();
            }
            return field_data;
        }

        private void submitbutton_clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Submit Button Selected");
            if (checkData() == false)
            {
                Console.WriteLine("Missing Data");
                MessageBox.Show("There are still blank fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Dictionary<string, string> log_data = read_fieldData();
            string[] newSample = remoteAPI.create_log(log_data);
            if (int.Parse(newSample[0]) != 0)
            {
                Console.WriteLine("Log Creation");
                this.button_samplenumber.Text = newSample[1];
                // Check to see if the client wants to print a label
                if (CHECKBOX_PrintLabel.Checked)
                {
                    this.userControl.create_log(int.Parse(newSample[0]), print_dymo_label:true);
                }
                else
                {
                    this.userControl.create_log(int.Parse(newSample[0]));
                }
                
            }
        }

        private void clear_fields()
        {
            foreach (Object obj in this.Controls)
            {
                if (obj is Panel)
                {
                    Panel panel_obj = obj as Panel;
                    if (panel_obj.HasChildren)
                    {
                        bool canClear = true;
                        // Look for Picturebox
                        foreach (Control child_object in panel_obj.Controls)
                        {
                            if (child_object is PictureBox)
                            {
                                PictureBox childObj = child_object as PictureBox;
                                if (childObj.Image == image_locked)
                                {
                                    canClear = false;
                                }
                            }
                        }
                        
                        if (canClear)
                        {
                            foreach (Control child_object in panel_obj.Controls)
                            {
                                if (child_object is TextBox)
                                {
                                    TextBox inputBox = child_object as TextBox;
                                    inputBox.Text = "";
                                }
                            }
                        }
                    }
                }
            }
            listbox_testlist.Items.Clear();
            testlist.reset();
        }

        private void button_clear_clicked(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void checkbox_datenow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_datenow.Checked)
            {
                dtp_date.Value = DateTime.UtcNow;
                dtp_time.Value = DateTime.UtcNow;
                dtp_date.Enabled = false;
                dtp_time.Enabled = false;
            }
            else
            {
                dtp_date.Enabled = true;
                dtp_time.Enabled = true;
            }
        }

        private void textbox_samplenum_DoubleClick(object sender, EventArgs e)
        {
            button_samplenumber.Text = "";
        }

        string previousIndex = "";
        
        private void setSampleNum()
        {
            if (String.IsNullOrEmpty(button_samplenumber.Text) && previousIndex != "")
            {
                MessageBox.Show("Reverting to previous value");
                button_samplenumber.Text = previousIndex;
                previousIndex = "";
                this.ActiveControl = label_samplenumberheader;
                return;
            }
            
        }
        
        private void button_exitform_Click(object sender, EventArgs e)
        {
            if (text_editor != null)
            {
                text_editor.Close();
            }
            this.Hide();
        }
        // Read a test log and put it into the textboxes.
        private void display_logdata(int log_index)
        {
            Dictionary<string, string[]> log_data = remoteAPI.fetch_log(log_index, is_lognum:true);
            // Write to all the textboxes inside the data form
            foreach (Control control in this.Controls)
            {
                // SampleNum label or such
                if (control.Tag != null)
                {

                }
                // Collect controls in panel
                else if (control is Panel)
                {
                    foreach (Control subcontrol in control.Controls)
                    {
                        if (subcontrol is TextBox && subcontrol.Tag != null)
                        {
                            (subcontrol as TextBox).Text = log_data[column_data[subcontrol.Tag.ToString()]][0];
                        }
                        else if (subcontrol is ListBox)
                        {
                            string[] tests_data = log_data["Tests Required"];
                            ListBox lb = subcontrol as ListBox;

                            // Clear the test log
                            testlist.reset();
                            lb.ClearSelected();
                            foreach (string test in tests_data)
                            {
                                // Make sure it is not null
                                if (String.IsNullOrEmpty(test) == false && lb.Items.Contains(test.Substring(1)))
                                {
                                    lb.SelectedItems.Add(test.Substring(1));
                                }

                            }
                        }
                    }
                }
            }
        }

        private void button_samplenumber_Click(object sender, EventArgs e)
        {
            Button button_samplenumber = sender as Button;
            
            if (button_samplenumber.HasChildren)
            {
                return;
            }

            TextBox newSampleNumber = new TextBox();
            newSampleNumber.Name = "textbox_newsamplenum";
            newSampleNumber.Dock = DockStyle.Fill;
            newSampleNumber.TextAlign = HorizontalAlignment.Left;
            newSampleNumber.BackColor = button_samplenumber.BackColor;
            newSampleNumber.ForeColor = button_samplenumber.ForeColor;
            newSampleNumber.Font = new Font(button_samplenumber.Font.FontFamily, 21);
            newSampleNumber.BorderStyle = BorderStyle.None;

            newSampleNumber.KeyDown += (s, key) =>
            {
                if (key.KeyCode == Keys.Enter)
                {
                    string sample_data = newSampleNumber.Text;
                    int parsed_double;
                    bool isNumeric = int.TryParse(sample_data, out parsed_double);
                    // Check to see if the text data is a digit
                    if (!isNumeric)
                    {
                        // Check to see if they used an L before it
                        isNumeric = int.TryParse(sample_data.Substring(1), out parsed_double);
                        if (!isNumeric)
                        {
                            MessageBox.Show("The sample number input is invalid/improper.", "Sample Num. Input Err",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            newSampleNumber.Dispose();
                            return;
                        }
                    }

                    // Convert to absolute (no negatives)
                    parsed_double = Math.Abs(parsed_double);

                    if (remoteAPI.check_samplelogexists(parsed_double))
                    {
                        DialogResult msgbox_result = MessageBox.Show("A log has already inherited that index. Would you like to modify the data?",
                            "Modify Log Data Request", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (msgbox_result == DialogResult.Yes)
                        {
                            display_logdata(parsed_double);
                        }
                       
                    }
                    else
                    {
                        // Verify Change
                        if (MessageBox.Show(String.Format("Changed Sample Number to '{0}'", parsed_double),
                            "Verify Change", MessageBoxButtons.YesNo & MessageBoxButtons.RetryCancel, 
                            MessageBoxIcon.Question) == DialogResult.No) {
                            newSampleNumber.Dispose();
                            return;
                        }
                    }
                    newSampleNumber.Dispose();
                    button_samplenumber.Text = remoteAPI.push_samplenum(parsed_double);

                }

                else if (key.KeyCode == Keys.Escape)
                {
                    newSampleNumber.Dispose();
                }
            };

            button_samplenumber.Controls.Add(newSampleNumber);
            newSampleNumber.Focus();
        }

        private void onEditorClosed(object sender, EventArgs e)
        {
            testlist.reset();
        }
        
        private void label_testlist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Edit Test List Data?", "Editor Request",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Modals.SQLReader sql_editor = new Modals.SQLReader();
            sql_editor.Show();
            sql_editor.FormClosed += onEditorClosed;

            /*
            text_editor = new Modals.Text_Editor(@"./config/test_list.dat");
            text_editor.Show();
            text_editor.FormClosed += onEditorClosed;
            */
        }
        
        private void label_testlist_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).Text = "+ Test List";
        }

        private void label_testlist_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).Text = "Test List";
        }

        private void CHECKBOX_PrintLabel_CheckedChanged(object sender, EventArgs e)
        {
            if (!CHECKBOX_PrintLabel.Checked)
            {
                foreach (Control control in LABEL_labelView.Controls)
                {
                    control.ForeColor = Color.FromArgb(150, 150, 150);
                }
            }
            else
            {
                foreach (Control control in LABEL_labelView.Controls)
                {
                    control.ForeColor = Color.Black;
                }
            }
        }

        private void btnPreviewAdmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<string> selections = new List<string>();
            foreach (string selection in listbox_testlist.SelectedItems)
            {
                selections.Add(selection);
            }

            Modals.Admittance_Info adInfo = new Modals.Admittance_Info(selections, read_fieldData(ClearAfterRead:false), this);
            adInfo.ShowDialog();
            
        }

        private void TestsListContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (listbox_testlist.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }


    }
}
