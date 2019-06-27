using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SQLite;
using System.IO;

namespace SampleNote.Main.Modals
{
    public partial class Admittance_Info : Form
    {
        // This class will be the handler for print preview 
        private PrintPreviewDialog dialogPrintPreview = new PrintPreviewDialog();
        private PrintDocument printDocument = new PrintDocument();
        Utility.UTILSQL_TestCode testCodeSQL = new Utility.UTILSQL_TestCode();
        string path_cliftonLogo;
        float collectedTime = 0.0f;

        // Produce Pens and Brushes
        Pen pBlack = new Pen(Color.Black); 
        Pen pGray = new Pen(Color.FromArgb(150, 150, 150));
        Brush bBlack = new SolidBrush(Color.Black);
        Brush bGray = new SolidBrush(Color.FromArgb(150, 150, 150));

        Font pageFont = new Font("Helvetica", 12);
        Font columnFont = new Font("Arial", 9, FontStyle.Bold);
        Font boldHelveticaFont = new Font("Helvetica", 12, FontStyle.Bold);
        Font codeFont = new Font("Consolas", 12);
        List<string> selectedTests = new List<string>();
        List<string[]> fieldTests;

        string internalReportsDirectoryPath;
        // Meant for Field Hours Checkbox
        string lastUpdate = "";

        public Admittance_Info(ListBox.SelectedObjectCollection selectedTests = null)
        {
            this.internalReportsDirectoryPath = Path.Combine(Environment.CurrentDirectory, "reports");

            // Check if Internal Reports Directory Path Exists
            if (!Directory.Exists(internalReportsDirectoryPath))
            {
                Console.WriteLine("Reproducing Internal Reports Directory: " + internalReportsDirectoryPath);
                Directory.CreateDirectory(internalReportsDirectoryPath);
            }
            foreach (string selectedTest in selectedTests)
            {
                this.selectedTests.Add(selectedTest);
            }
            this.fieldTests = testCodeSQL.GetFieldTests();
            foreach (string[] fieldTest in fieldTests)
            {
                selectedTests.Add(fieldTest[1]);
            }
            
            this.path_cliftonLogo = Path.Combine(Environment.CurrentDirectory , @"img\Clifton_Logo.GrayPrint.png");

            InitializeComponent();
            new Utility.HeaderUtility(Form_Header);

            btnCurrentLog.Text = "Log: CAL-" + (Directory.GetFiles(internalReportsDirectoryPath).Length + 1).ToString();
            // Append field tests to combobox
            foreach (string[] test_data in fieldTests)
            {
                cbx_HourlyTesting.Items.Add(test_data[1]);
            }

            this.dialogPrintPreview.ClientSize = new Size(500, 700);
            // Modify the print preview dialog properties 
            btnPreviewPrint.Click += new System.EventHandler(this.eventPrintPreview);
            printDocument.PrintPage += new PrintPageEventHandler(designPage);
            // Replicate Sheet into PDF

            dialogPrintPreview.FormClosed += (s, e) =>
            {
                this.Show();
            };
        }
        
        void designPage(object sender, PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;
            // Assing the variables
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;

            // Accounting Copy
            g.DrawLine(pGray, 25, 48, pageWidth - 25, 48);
            g.DrawString("Accounting Copy", new Font("Arial", 10, FontStyle.Bold), bGray, 60, 25);

            //g.DrawString("Project Name", pageFont, bBlack, 25, 85);

            // Clifton Image
            Image imageFile = Image.FromFile(path_cliftonLogo);
            Graphics newGraphics = Graphics.FromImage(imageFile);
            e.Graphics.DrawImage(imageFile, new Point(25, 20));
            newGraphics.Dispose();

            // VEHICLE DATA
            g.DrawString("VEHICLE", columnFont, bBlack, 25, 65);

            g.DrawString("UNIT:", columnFont, bBlack, 25, 90);
            g.DrawString(tb_Unit.Text, new Font("Helvetica", 9), bBlack, 25 + g.MeasureString("UNIT: ", new Font("Helvetica", 9)).Width, 90);

            g.DrawString("DAILY RATE:", columnFont, bBlack, 25, 120);
            g.DrawString(cbx_DailyRate.Text, new Font("Helvetica", 9), bBlack, 25 + g.MeasureString("DAILY RATE: ", new Font("Helvetica", 9)).Width, 120);

            g.DrawString("AND    KM DRIVEN:", columnFont, bBlack, 205, 90);
            g.DrawString(cbx_kmDriven.Text, new Font("Helvetica", 9), bBlack, 205 + g.MeasureString("AND    KM DRIVEN: ", new Font("Helvetica", 9)).Width, 90);

            g.DrawString("OR     TRIPS TO SITE:", columnFont, bBlack, 205, 120);
            g.DrawString(cbx_TripsToSite.Text, new Font("Helvetica", 9), bBlack, 205 + g.MeasureString("OR     TRIPS TO SITE: ", new Font("Helvetica", 9)).Width, 120);
            
            // TIME DATA
            g.DrawString("TIME (hour)", columnFont, bBlack, 450, 65);

            g.DrawString("MOB:", columnFont, bBlack, 450, 90);
            g.DrawString(tb_Mob.Text, new Font("Helvetica", 9), bBlack, 450 + g.MeasureString("MOB: ", new Font("Helvetica", 9)).Width, 90);

            g.DrawString("STANDBY:", columnFont, bBlack, 450, 120);
            g.DrawString(tb_StandBy.Text, new Font("Helvetica", 9), bBlack, 450 + g.MeasureString("STANDBY: ", new Font("Helvetica", 9)).Width, 120);

            g.DrawString("TESTING:", columnFont, bBlack, 650, 90);
            g.DrawString(tb_Testing.Text, new Font("Helvetica", 9), bBlack, 650 + g.MeasureString("TESTING: ", new Font("Helvetica", 9)).Width, 90);

            g.DrawString("OTHER:", columnFont, bBlack, 650, 120);
            g.DrawString(tb_Other.Text, new Font("Helvetica", 9), bBlack, 650 + g.MeasureString("OTHER: ", new Font("Helvetica", 9)).Width, 120);


            // Write Reciept Number
            g.DrawString(btnCurrentLog.Text.Substring(5), boldHelveticaFont, bGray, pageWidth - g.MeasureString(btnCurrentLog.Text.Substring(5), boldHelveticaFont).Width - 25, 25);
            int table_yOffset = 160;
            // Draw Columns
            g.DrawLine(pGray, 25, table_yOffset + 25, pageWidth - 25, table_yOffset + 25);
            g.DrawLine(pGray, 25, table_yOffset + 22, pageWidth - 25, table_yOffset + 22);
            g.DrawString("CODE", columnFont, bBlack, 35, table_yOffset + 3);
            g.DrawLine(pGray, 40 + g.MeasureString("CODE", columnFont).Width, table_yOffset - 5, 40 + g.MeasureString("CODE", columnFont).Width, table_yOffset + 275);

            g.DrawString("TESTS REQUIRED", columnFont, bBlack, 250, table_yOffset + 5);
            g.DrawLine(pGray, 560, table_yOffset - 5, 560, table_yOffset + 275);

            g.DrawString("QTY.", columnFont, bBlack, 570, table_yOffset + 3);
            g.DrawLine(pGray, 615, table_yOffset - 5, 615, table_yOffset + 275);

            g.DrawString("COST", columnFont, bBlack, 630, table_yOffset + 3);
            g.DrawLine(pGray, 685, table_yOffset - 5, 685, table_yOffset + 275);

            g.DrawString("REMARKS", columnFont, bBlack, 720, table_yOffset + 3);

            g.DrawRectangle(pGray, new Rectangle(25, table_yOffset - 5, pageWidth - 50, (table_yOffset + 275) - (table_yOffset - 5)));

            
            // Draw table of tests
            for (int test_index = 0; test_index < 10; test_index++)
            {
                if (selectedTests != null && selectedTests.Count-1 >= test_index)
                {                    
                    string testName = selectedTests[test_index].ToString();
                    string[] testData = testCodeSQL.FetchRecordWhere(string.Format("TestName='{0}'", testName));
                    // Draw NCode
                    g.DrawString(testData[0], new Font("Helvetica", 9), bBlack, 28, table_yOffset + ((test_index + 1) * 25)+5);
                    // Test Name
                    g.DrawString(testData[1], new Font("Helvetica", 9), bBlack, 85, table_yOffset + ((test_index + 1) * 25)+5);
                    // Quantity: For Field Tests check for N1.23 ... Nuclear Method
                    if (testData[0] == "N1.23" || testData[1] == lastUpdate)
                    {
                        if (checkbox_Field.Checked)
                        {
                            g.DrawString(collectedTime.ToString()+"h", new Font("Helvetica", 9), bBlack, 570, table_yOffset + ((test_index + 1) * 25) + 5);
                        }
                    }                    
                    else
                    {
                        g.DrawString("1", new Font("Helvetica", 9), bBlack, 570, table_yOffset + ((test_index + 1) * 25) + 5);
                    }
                    Console.WriteLine(testName);
                    
                   
                }
                //string test_name = test_data[test_index];

                g.DrawLine(pGray, 25, (table_yOffset + 25) + ((test_index + 1) * 25), pageWidth - 25, (table_yOffset + 25) + ((test_index + 1) * 25));
            }
            

            g.DrawString("REMARKS: ", columnFont, bBlack, 25, 460);
            g.DrawString(tb_Remarks.Text, new Font("Arial", 10), bBlack, 25 + (int)g.MeasureString("REMARKS: ", columnFont).Width, 458);
            g.DrawString("REVIEWED BY: ________________________", columnFont, bBlack, pageWidth - (int)g.MeasureString("REVIEWED BY: ________________________", columnFont).Width - 25, 500);

            // Draw Divider Line
            g.DrawLine(pGray, 0, pageHeight / 2, pageWidth, pageHeight / 2);
        }

        void eventPrintPreview(object sender, EventArgs e)
        {
            this.Hide();
            collectedTime = 0.0f;
            foreach (Control control in groupbox_TimeInfo.Controls)
            {
                if (control is TextBox)
                {
                    float collectedNum;
                    float.TryParse(control.Text, out collectedNum);
                    // No if statements to see if the parse is possible since a failed parse would return 0
                    collectedTime += collectedNum;
                }
            }
            Console.WriteLine("Recieved: " + collectedTime.ToString());
            
            // Preview Dialog
            printDocument.DocumentName = "Sample Reciept";
            dialogPrintPreview.Document = printDocument;
            dialogPrintPreview.ShowDialog();
            
        }

        private void button_exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            // Clear Vehicle Combo boxes
            foreach (Control control in groupbox_VehicleInfo.Controls)
            {
                if (control is ComboBox)
                {
                    control.Text = string.Empty;
                }
            }
            // Clear Time Combo Boxes
            foreach (Control control in groupbox_TimeInfo.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
            // Uncheck Field Test Checkboxes
            foreach (Control control in groupbox_Other.Controls)
            {
                if (control is CheckBox)
                {
                    (control as CheckBox).Checked = false;
                }
            }
        }

        private void checkbox_HourlyTesting_CheckedChanged(object sender, EventArgs e)
        {
            cbx_HourlyTesting.Enabled = checkbox_HourlyTesting.Checked;
            if (!checkbox_HourlyTesting.Checked)
            {
                if (selectedTests.Contains(lastUpdate))
                {
                    selectedTests.Remove(lastUpdate);
                }
            }
            
        }

        // Parse the Test List and add the Nuclear N1.23 if it hasn't been added
        private void checkbox_Field_CheckedChanged(object sender, EventArgs e)
        {
            string[] recordData = testCodeSQL.FetchRecordWhere(string.Format("NCode='N1.23'"));
            // Does not contain N1.23
            if (!selectedTests.Contains(recordData[1]))
            {
                selectedTests.Add(recordData[1]);
            }
        }

        private void checkbox_Field_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkbox_Field.Checked)
            {
                checkbox_HourlyTesting.Checked = false;
            }
            else
            {
                string[] recordData = testCodeSQL.FetchRecordWhere(string.Format("NCode='N1.23'"));
                if (selectedTests.Contains(recordData[1]))
                {
                    selectedTests.Remove(recordData[1]);
                }
            }
            //checkbox_Field.Checked = !checkbox_HourlyTesting.Checked;
        }

        private void checkbox_HourlyTesting_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkbox_HourlyTesting.Checked)
            {
                checkbox_Field.Checked = false;
            }
            else
            {
                // Check for any field tests added inside of tests
                foreach (string[] fieldTestDat in fieldTests)
                {
                    if (selectedTests.Contains(fieldTestDat[1]))
                    {
                        selectedTests.Remove(fieldTestDat[1]);
                    }
                }
            }
            //checkbox_HourlyTesting.Checked = !checkbox_Field.Checked;
        }
        private void addHourTest()
        {
            // Add test as log
            if (checkbox_HourlyTesting.Checked)
            {
                if (string.IsNullOrEmpty(cbx_HourlyTesting.Text))
                {
                    return;
                }

                if (lastUpdate != "")
                {
                    selectedTests.Remove(lastUpdate);
                }
                lastUpdate = cbx_HourlyTesting.Text;
                selectedTests.Add(cbx_HourlyTesting.Text);
            }
        }

        private void cbx_HourlyTesting_TextUpdate(object sender, EventArgs e)
        {
            addHourTest();
        }
        
        private void cbx_HourlyTesting_SelectedIndexChanged(object sender, EventArgs e)
        {
            addHourTest();
        }

        private void btnCurrentLog_Click(object sender, EventArgs e)
        {
            dialog_ReportLogFolder.ShowDialog();
        }
    }
}
