using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace SampleNote.Main.Forms
{
    public partial class User_Control : Form
    {
        // List variables
        Dictionary<string, int> columnPositions = new Dictionary<string, int>();
        Utility.ConfigUtility config_columns = new Utility.ConfigUtility(@"./config/column.positions.config");
         Utility.CacheUtility cache = new Utility.CacheUtility();
        // Construct the individual form classes and API
        Forms.SampleLog_FormEditor editor;
        Forms.Data form_data;
        Forms.Monitor monitor;
        Modals.History_Reader history_reader;
        Modules.API remoteAPI;
        // Column Draggin Variables
        Label column_dragging = null;
        int column_offsetFromLeft = 0;


        public User_Control(Modules.API remoteAPI)
        {
            InitializeComponent();
            panel_usercontrol.Width = 3;
            this.form_data = new Forms.Data(remoteAPI, this);
            this.remoteAPI = remoteAPI;
            new Utility.HeaderUtility(Form_Header, sizable: true, canHideHeader: true);
            Dialog_BakFile.Filter = remoteAPI.fetch_extensions();


            // Log column positions
            foreach (Control columnObject in panel_columns.Controls)
            {
                if (columnObject is Label && !string.IsNullOrEmpty(columnObject.Tag.ToString()))
                {
                    // Add from the config file
                    columnPositions.Add(columnObject.Tag.ToString(), Int32.Parse(config_columns[
                        columnObject.Tag.ToString()]));
                    columnObject.Location = new Point(columnPositions[columnObject.Tag.ToString()],
                        columnObject.Location.Y);
                    //columnPositions.Add(columnObject.Tag.ToString(), columnObject.Location.X);
                }
            }

            editor = new Forms.SampleLog_FormEditor(panel_contents, remoteAPI, columnPositions, DataExpansionTooltip);
            monitor = new Forms.Monitor(remoteAPI, editor);
            
            this.Show();
            // Apply location movements on the columns
            foreach (Control control_column in panel_columns.Controls)
            {
                if (control_column is Label)
                {
                    control_column.MouseEnter += (s, _) => { control_column.ForeColor = Color.FromArgb(200, 200, 200); };
                    control_column.MouseLeave += (s, _) => { control_column.ForeColor = Color.White; };
                    control_column.MouseDown += (sender, _) => { column_dragging = sender as Label; column_offsetFromLeft = (Cursor.Position.X - this.Left) - (sender as Label).Left; };
                    control_column.MouseUp += (s, _) =>
                    {
                        adjustColumns();
                        column_dragging = null;
                        config_columns[control_column.Tag.ToString()] = control_column.Location.X.ToString();
                    };
                    control_column.MouseMove += dragColumn;
                }
            }
        }

        private void adjustColumns()
        {
            // Set the new column position variable
            columnPositions[column_dragging.Tag.ToString()] = column_dragging.Location.X;
            // Find the next columns left position
            int nextColumnLeft = 0;
            Control prevColumn = null;
            foreach (Control control in panel_columns.Controls)
            {
                if (control.TabIndex - column_dragging.TabIndex == 1)
                {
                    nextColumnLeft = control.Left;
                }
                // Resize the controls to the left
                if (control.TabIndex - column_dragging.TabIndex == -1)
                {
                    prevColumn = control;
                }
            }

            foreach (Control control in panel_contents.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control subControl in control.Controls)
                    {
                        // Left
                        if (subControl.Tag == prevColumn.Tag)
                        {
                            subControl.Width = column_dragging.Left - prevColumn.Left - 5;
                            
                            //subControl.BackColor = Color.Firebrick;
                        }
                        // Now
                        if (subControl.Tag == column_dragging.Tag)
                        {
                            if (subControl.Tag.ToString() == "Tests Required")
                            {
                                subControl.Location = new Point(column_dragging.Location.X, subControl.Location.Y);
                                subControl.Width = this.Width - nextColumnLeft - column_dragging.Left;
                            }
                            else
                            {
                                subControl.Location = new Point(column_dragging.Location.X, subControl.Location.Y);
                                if (nextColumnLeft != 0)
                                {
                                    //subControl.BackColor = Color.BlueViolet;
                                    subControl.Width = nextColumnLeft - column_dragging.Left - 5;
                                }
                            }
                            
                        }
                       
                    }
                }
            }
        }

        private void dragColumn(object sender, EventArgs e)
        {
            Label myColumn = sender as Label;

            if (myColumn != column_dragging)
            {
                return;
            }

            Point cursor_relativePoint = this.PointToClient(Cursor.Position);
            int newX = cursor_relativePoint.X - column_offsetFromLeft;
            // Check for labels in contact
            foreach (Control otherColumn in panel_columns.Controls)
            {
                // Make sure the column is not the same as the current column
                if (otherColumn != myColumn)
                {
                    // Check if it is passing any unallowed areas
                    if (otherColumn.TabIndex - myColumn.TabIndex == -1) // Other Column is on left side
                    {
                        if (newX < otherColumn.Right) // myColumn.Left
                        {
                            newX = otherColumn.Right + 2;
                            break;
                        }
                    }

                    if (otherColumn.TabIndex - myColumn.TabIndex == 1) // Other Column is on right side
                    {
                        if (newX + myColumn.Width > otherColumn.Left)
                        {
                            newX = otherColumn.Left - myColumn.Width - 2;
                            break;
                        }
                    }
                }
            }

            myColumn.Location = new Point(newX, myColumn.Location.Y);
            adjustColumns();
            
        }

        bool menu_state = false;

        // Creates a panel log holding the data contained from the index
        public void create_log(int index, bool print_dymo_label=false)
        {
            editor.createLog(index, print_dymo_label);
        }
        // Adjusts the menu panels width
        private void adjustPanelWidth()
        {
            if (menu_state == false)
            {
                panel_usercontrol.Width = 2;
                panel_menuUnderline.Visible = false;
                FormName.ForeColor = Color.White;
                panel_usercontrol.BackColor = Color.FromArgb(255, 1, 78, 141);
            }
            else
            {
                panel_usercontrol.Width = 308; // panel_menubutton.Width; 
                panel_menuUnderline.Visible = true;
                FormName.ForeColor = Color.FromArgb(0, 30, 43);
                panel_usercontrol.BackColor = Color.FromArgb(255, 25, 25, 25);
            }
        }
        // Shows the data handling form
        private void button_opendataform_Click(object sender, EventArgs e)
        {
            form_data.Show();
        }
        private void button_createsamplelog_Click(object sender, EventArgs e)
        {
            form_data.Show();
        }
        // Prommpt a confirmation box then proceed to close the API and exit out the form
        private void button_safeExit_Click(object sender, EventArgs e)
        {
            DialogResult msgBoxResult = MessageBox.Show("Are you sure you want to close SampleNote?",
                  "Confirmation",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);

            if (msgBoxResult == DialogResult.No)
            {
                return;
            }

            remoteAPI.quit();
            Application.Exit();
        }
        private void button_exitform_Click(object sender, EventArgs e)
        {
            DialogResult msgBoxResult = MessageBox.Show("Are you sure you want to close SampleNote?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (msgBoxResult == DialogResult.No)
            {
                return;
            }
            remoteAPI.quit();
            Application.Exit();
        }
        // Change the form menu state variable and then adjust the panel
        private void FormName_MouseDown(object sender, MouseEventArgs e)
        {
            menu_state = !menu_state;
            adjustPanelWidth();
        }
        // Resize the user control / menu to indicate the user that there will be an adjustment to the sizing 
        private void FormName_MouseEnter(object sender, EventArgs e)
        {
            panel_usercontrol.Width = 7;
        }
        private void FormName_MouseLeave(object sender, EventArgs e)
        {
            adjustPanelWidth();
        }
        // Create a backup file wherever the user wants
        private void button_createbackup_Click(object sender, EventArgs e)
        {
            if (Dialog_BakFile.ShowDialog() == DialogResult.OK)
            {
                // I don't really want to use goto but it makes this a lot easier and cleaner
                retryBackup:
                bool backup_success = remoteAPI.write_backupfile(Dialog_BakFile.FileName);
                if (backup_success)
                {
                    Console.WriteLine("Succeessful Backup");
                }
                else
                {
                    if (MessageBox.Show("An error occured while writing a new backup file!", "Backup Unsuccessful",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                    {
                        goto retryBackup;
                    }

                }
            }
        }
        // Creates a quick backup file without prompting any dialog. The file is saved in the program folders.
        private void button_quickbackup_Click(object sender, EventArgs e)
        {
            bool backup_success = remoteAPI.write_backupfile(String.Format(@"{0}/saves/{1}{2}", Environment.CurrentDirectory, DateTime.Now.ToString("yyyy-mm-dd hh-mmtt"), remoteAPI.fetch_extensions("bak")));
            if (backup_success)
            {
                Console.WriteLine("Successful Quick Backup");
            }
            else
            {
                MessageBox.Show("Unable to create quick backup!", "Backup Unsuccessful",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Display the form monitor
        private void button_openmonitor_Click(object sender, EventArgs e)
        {
            monitor.Show();
        }
        // Display the local web file general
        private void button_generalhelp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        // Open the control designer form as a Modal
        private void button_customization_Click(object sender, EventArgs e)
        {
            new Modals.Control_Designer().Show();
        }
        // Prompts the history form as a modal
        private void button_showhistory_Click(object sender, EventArgs e)
        {
            if (history_reader != null)
            {
                history_reader.Close();
                history_reader.Dispose();
                history_reader = null;
            }
            history_reader = new Modals.History_Reader();
        }
    }
}
