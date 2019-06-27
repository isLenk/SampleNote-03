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
        Utility.ConfigUtility config_columns = new Utility.ConfigUtility(@"./config/column.positions.config");
        Modules.API remoteAPI;
        Forms.SampleLog_FormEditor editor;
        Dictionary<string, int> columnPositions = new Dictionary<string, int>();
        int panel_height;
        Label column_dragging = null;
        int column_offsetFromLeft = 0;

        public Monitor(Modules.API remoteAPI, SampleLog_FormEditor ucEditor)
        {
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header, sizable: true, canHideHeader: true);
            this.remoteAPI = remoteAPI;
            
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
            ucEditor.monitor_object = editor;
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
                        if (subControl.Tag == prevColumn.Tag)
                        {
                            subControl.Width = column_dragging.Left - prevColumn.Left - 5;

                            //subControl.BackColor = Color.Firebrick;
                        }

                        if (subControl.Tag == column_dragging.Tag)
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
