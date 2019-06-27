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
        //private PrintPreviewDialog dialogPrintPreview = new PrintPreviewDialog();
        private PrintDocument printDocument = new PrintDocument();
        private cPrintPreviewDialog myPrintPreview = new cPrintPreviewDialog();

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
        Dictionary<string, string> sampleData;
        Form dataForm;
        string internalReportsDirectoryPath;
        // Meant for Field Hours Checkbox
        string lastUpdate = "";

        public Admittance_Info(List<string> selectedTests, Dictionary<string, string> sampleData, Form dataForm)
        {
            this.internalReportsDirectoryPath = Path.Combine(Environment.CurrentDirectory, "reports");
            this.sampleData = sampleData;
            this.dataForm = dataForm;
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

            btnCurrentLog.Text = String.Format("Log: 01- {0:D5}", (15999+Directory.GetFiles(internalReportsDirectoryPath).Length + 1).ToString());
            // Append field tests to combobox
            foreach (string[] test_data in fieldTests)
            {
                cbx_HourlyTesting.Items.Add(test_data[1]);
            }
            
            //this.dialogPrintPreview.ClientSize = new Size(500, 700);
            // Modify the print preview dialog properties 
            btnPreviewPrint.Click += new System.EventHandler(this.eventPrintPreview);
            //printDocument.PrintPage += new PrintPageEventHandler(designPage);
            // Replicate Sheet into PDF
            myPrintPreview.AdmitForm = this;
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
            printDocument.DocumentName = "Sample Receipt";
            bool Field = false;
            if (checkbox_Field.Checked || checkbox_HourlyTesting.Checked)
            {
                Field = true;
            }
            myPrintPreview.ViewDocument(printDocument, readData(), selectedTests, lastUpdate, Field, collectedTime, fieldTests);
            
        }

        private Dictionary<string, string> readData()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("Sample.Number", sampleData["A"]);
            data.Add("Sample.Date", sampleData["F"]);
            data.Add("Sample.Location", sampleData["D"]);
            data.Add("Sample.Project_Number", sampleData["B"]);
            data.Add("Sample.Project_Name", sampleData["C"]);
            data.Add("Sample.Client", sampleData["E"]);
            data.Add("Sample.Technician", sampleData["K"]);
            data.Add("Vehicle.Unit", tb_Unit.Text);
            data.Add("Vehicle.Daily_Rate", cbx_DailyRate.Text);
            data.Add("Vehicle.Km_Driven", cbx_kmDriven.Text);
            data.Add("Vehicle.Trips_To_Site", cbx_TripsToSite.Text);
            data.Add("Time.Mob", tb_Mob.Text);
            data.Add("Time.StandBy", tb_StandBy.Text);
            data.Add("Time.Testing", tb_Testing.Text);
            data.Add("Time.Other", tb_Other.Text);
            data.Add("Remarks", tb_Remarks.Text);
            data.Add("Log.ReceiptNumber", btnCurrentLog.Text.Substring(5));
            
            return data;
        }

        private void button_exitform_Click(object sender, EventArgs e)
        {
            dataForm.Show();
            this.Close();
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
