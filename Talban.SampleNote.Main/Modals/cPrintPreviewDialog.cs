using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace SampleNote.Main.Modals
{
    public partial class cPrintPreviewDialog : Form
    {

        Utility.UTILSQL_TestCode testCodeSQL = new Utility.UTILSQL_TestCode();
        string path_cliftonLogo;
        Font pageFont = new Font("Helvetica", 12);
        Font columnFont = new Font("Arial", 9, FontStyle.Bold);
        Font boldHelveticaFont = new Font("Helvetica", 12, FontStyle.Bold);
        Font codeFont = new Font("Consolas", 12);
        Font helveticaFont = new Font("Helvetica", 9);
        // Produce Pens and Brushes
        Pen pBlack = new Pen(Color.Black);
        Pen pGray = new Pen(Color.FromArgb(80, 80, 80));
        Brush bBlack = new SolidBrush(Color.Black);
        Brush bGray = new SolidBrush(Color.FromArgb(80, 80, 80));
        List<string> selectedTests;
        Dictionary<string, string> data;
        List<string[]> fieldTests;
        string lastUpdate;
        float collectedTime;
        string internalReportsDirectoryPath;
        public Form AdmitForm;
        bool Field;
        Utility.ConfigUtility pathsConfig = new Utility.ConfigUtility(@"./config/general.path.config");

        public cPrintPreviewDialog()
        {
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header, sizable: true);

            this.path_cliftonLogo = Path.Combine(Environment.CurrentDirectory, @"img\Clifton_Logo.GrayPrint.png");

        }

        private PrintDocument printDocument = new PrintDocument();
        public void ViewDocument(PrintDocument doc, Dictionary<string, string> reportData, List<string> selectedTests, string lastUpdate, bool Field, float collectedTime, List<string[]> fieldTests)
        {
            //this.internalReportsDirectoryPath = Path.Combine(Environment.CurrentDirectory, "reports");
            // @"\\EgnyteDrive\SSO - clifton.egnyte.com\Shared\Corporate\Lab\Regina\Samplenote"
            string pdf_savepath = pathsConfig["Admittance.PDF.SavePath"];
            if (pdf_savepath == "self")
            {
                this.internalReportsDirectoryPath = Path.Combine(Environment.CurrentDirectory, "reports");
            }
            else {
                // Check path exists
                if (Directory.Exists(pdf_savepath))
                {
                    this.internalReportsDirectoryPath = pdf_savepath;
                }
                else
                {
                    this.internalReportsDirectoryPath = Path.Combine(Environment.CurrentDirectory, "reports");
                }
            }
            
            if (!Directory.Exists(this.internalReportsDirectoryPath))
            {
                MessageBox.Show("Directory does not exist");
                this.internalReportsDirectoryPath = Path.Combine(Environment.CurrentDirectory, "reports");
            }
            btnPromptDirectoryDialog.Text = this.internalReportsDirectoryPath;
            Tooltip.SetToolTip(btnPromptDirectoryDialog, this.internalReportsDirectoryPath);
            // Crudely prepared. Since I'm sick of this 4-23
            this.collectedTime = collectedTime;
            this.Field = Field;
            this.lastUpdate = lastUpdate;
            this.selectedTests = selectedTests;
            this.data = reportData;
            this.fieldTests = fieldTests;

            // Set up Document
            printDocument.DocumentName = "Report - " + data["Log.ReceiptNumber"];
            DocumentPreview.Document = printDocument;
            printDocument.PrintPage +=
                new System.Drawing.Printing.PrintPageEventHandler(designPage);

            // Set up Controls
            lblReportName.Text = printDocument.DocumentName;

            printDocument.DefaultPageSettings.PaperSize = new PaperSize("a4", 850, 1100);
            ShowDialog();
        }

        /*
         * PROJECT DATA
         * DATE
         * CLIENT P.O
         * TECHNICIAN, ADMITTED BY
         *      LOCATION
         *      PROJECT NAME
         *      CLIENT
        */


        void designPage(object sender, PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;
            // Assing the variables
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;

            int offset = 160; // Temporary to determine the offset required to fit the Sample data
            // Accounting Copy
            g.DrawLine(pGray, 25, 48, pageWidth - 25, 48);
            g.DrawString("Accounting Copy", new Font("Arial", 10, FontStyle.Bold), bGray, 60, 25);

            //g.DrawString("Project Name", pageFont, bBlack, 25, 85);

            // Clifton Image
            Image imageFile = Image.FromFile(path_cliftonLogo);
            Graphics newGraphics = Graphics.FromImage(imageFile);
            e.Graphics.DrawImage(imageFile, new Point(25, 20));
            newGraphics.Dispose();

            // SAMPLE DATA
            g.DrawString("DATE ___________________________________", columnFont, bBlack, 100 - g.MeasureString("DATE ", columnFont).Width, 75);
            g.DrawString(DateTime.Parse(data["Sample.Date"]).ToString("dd / MMM / yyyy"), helveticaFont, bBlack, 105, 75);
            g.DrawString("PROJECT # ___________________________________", columnFont, bBlack, 100 - g.MeasureString("PROJECT # ", columnFont).Width, 95);
            g.DrawString(data["Sample.Project_Number"], helveticaFont, bBlack, 105, 95);
            g.DrawString("CLIENT PO ___________________________________", columnFont, bBlack, 100 - g.MeasureString("CLIENT PO ", columnFont).Width, 115);
            // REQUIRED BLANK
            g.DrawString("TECHNICIAN ___________________________________", columnFont, bBlack, 100 - g.MeasureString("TECHNICIAN ", columnFont).Width, 135);
            g.DrawString(data["Sample.Technician"], helveticaFont, bBlack, 105, 135);

            g.DrawString("LOCATION ________________________________________", columnFont, bBlack, 520 - g.MeasureString("LOCATION ", columnFont).Width, 75);
            g.DrawString(data["Sample.Location"], helveticaFont, bBlack, 520, 75);
            g.DrawString("PROJECT NAME ________________________________________", columnFont, bBlack, 520 - g.MeasureString("PROJECT NAME ", columnFont).Width, 95);
            g.DrawString(data["Sample.Project_Name"], helveticaFont, bBlack, 520, 95);
            g.DrawString("CLIENT ________________________________________", columnFont, bBlack, 520 - g.MeasureString("CLIENT ", columnFont).Width, 115);
            g.DrawString(data["Sample.Client"], helveticaFont, bBlack, 520, 115);

            // VEHICLE DATA
            g.DrawString("VEHICLE", columnFont, bBlack, 25, 65 + offset);

            g.DrawString("UNIT: ___________________", columnFont, bBlack, 25, 90 + offset);
            g.DrawString(data["Vehicle.Unit"], helveticaFont, bBlack, (30 + g.MeasureString("UNIT:  __________", helveticaFont).Width) - (int)(Math.Floor(g.MeasureString(data["Vehicle.Unit"], helveticaFont).Width / 2)), 90 + offset);

            g.DrawString("DAILY RATE: ____________", columnFont, bBlack, 25, 120 + offset);
            g.DrawString(data["Vehicle.Daily_Rate"], helveticaFont, bBlack, (30 + g.MeasureString("DAILY RATE:  ____", helveticaFont).Width) - (int)(Math.Floor(g.MeasureString(data["Vehicle.Daily_Rate"], helveticaFont).Width / 2)), 120 + offset);

            g.DrawString("KM DRIVEN: ________________", columnFont, bBlack, 205, 90 + offset);
            g.DrawString(data["Vehicle.Km_Driven"], helveticaFont, bBlack, (210 + g.MeasureString("KM DRIVEN:  _______", helveticaFont).Width) - (int)(Math.Floor(g.MeasureString(data["Vehicle.Km_Driven"], helveticaFont).Width / 2)), 90 + offset);

            g.DrawString("TRIPS TO SITE: ______________", columnFont, bBlack, 205, 120 + offset);
            g.DrawString(data["Vehicle.Trips_To_Site"], helveticaFont, bBlack, (210 + g.MeasureString("TRIPS TO SITE:  ____", helveticaFont).Width) - (int)(Math.Floor(g.MeasureString(data["Vehicle.Trips_To_Site"], helveticaFont).Width/2)), 120 + offset);

            // TIME DATA
            g.DrawString("TIME (hour)", columnFont, bBlack, 450, 65 + offset);

            g.DrawString("MOB: ______________________", columnFont, bBlack, 450, 90 + offset);
            g.DrawString(data["Time.Mob"], helveticaFont, bBlack, (450 + g.MeasureString("MOB: ___________", helveticaFont).Width) - (int)(Math.Floor(g.MeasureString(data["Time.Mob"], helveticaFont).Width/2)), 90 + offset);

            g.DrawString("STANDBY: __________________", columnFont, bBlack, 450, 120 + offset);
            g.DrawString(data["Time.StandBy"], helveticaFont, bBlack, (450 + g.MeasureString("STANDBY: _______", helveticaFont).Width) - (int)(Math.Floor(g.MeasureString(data["Time.StandBy"], helveticaFont).Width / 2)), 120 + offset);

            g.DrawString("TESTING: _____________", columnFont, bBlack, 650, 90 + offset);
            g.DrawString(data["Time.Testing"], helveticaFont, bBlack, (650 + g.MeasureString("TESTING: _____", helveticaFont).Width) - (int)(Math.Floor(g.MeasureString(data["Time.Testing"], helveticaFont).Width / 2)), 90 + offset);

            g.DrawString("OTHER: _______________", columnFont, bBlack, 650, 120 + offset);
            g.DrawString(data["Time.Other"], helveticaFont, bBlack, (650 + g.MeasureString("OTHER: _______", helveticaFont).Width) - (int)(Math.Floor(g.MeasureString(data["Time.Other"], helveticaFont).Width / 2)), 120 + offset);
            
            // Write Reciept Number
            g.DrawString(data["Log.ReceiptNumber"], boldHelveticaFont, bGray, pageWidth - g.MeasureString(data["Log.ReceiptNumber"], boldHelveticaFont).Width - 50, 25);
            int table_yOffset = 160;
            // Lazy way to offset extra
            offset += 50;

            // Draw Columns
            g.DrawLine(pGray, 25, table_yOffset + 25 + offset, pageWidth - 50, table_yOffset + 25 + offset);
            g.DrawLine(pGray, 25, table_yOffset + 22 + offset, pageWidth - 50, table_yOffset + 22 + offset);
            g.DrawString("CODE", columnFont, bBlack, 35, table_yOffset + 3 + offset);

            g.DrawString("TESTS REQUIRED", columnFont, bBlack, 250, table_yOffset + 5 + offset);

            g.DrawString("SAMPLE #", columnFont, bBlack, 485, table_yOffset + 5 + offset);

            g.DrawString("QTY.", columnFont, bBlack, 570, table_yOffset + 3 + offset);

            g.DrawString("COST", columnFont, bBlack, 630, table_yOffset + 3 + offset);

            g.DrawString("REMARKS", columnFont, bBlack, 715, table_yOffset + 3 + offset);

            int additionalOffset = 0;
            // Draw table of tests
            for (int test_index = 0; test_index < 10; test_index++)
            {
                if (selectedTests != null && selectedTests.Count - 1 >= test_index)
                {
                    string testName = selectedTests[test_index].ToString();
                    string[] testData = testCodeSQL.FetchRecordWhere(string.Format("TestName='{0}' or Nickname='{0}'", testName));
                    

                    // Test Name
                    if (g.MeasureString(testData[1], helveticaFont).Width > 470- 100)
                    {
                        string first_line = testData[1];
                        while ((g.MeasureString(first_line, helveticaFont).Width > 470 - 100))
                            first_line = first_line.Remove(first_line.Length - 1);
                        g.DrawString(first_line, helveticaFont, bBlack, 85, table_yOffset + ((test_index + 1) * 25) + 5 + offset + additionalOffset);
                        g.DrawString(testData[1].Substring(first_line.Length), helveticaFont, bBlack, 85, table_yOffset + ((test_index + 1) * 25) + 5 + offset + helveticaFont.Height + 3 + additionalOffset);

                        additionalOffset += helveticaFont.Height + 5;
                    }
                    else
                    {
                        g.DrawString(testData[1], helveticaFont, bBlack, 85, table_yOffset + ((test_index + 1) * 25) + 5 + offset + additionalOffset);
                    }
                    // Quantity: For Field Tests check for N1.23 ... Nuclear Method
                    bool testIsField = false;
                    foreach (string[] testInfo in fieldTests)
                    {
                        if (testInfo[1] == testData[1])
                        {
                            testIsField = true;
                        }
                    }

                    // Draw NCode
                    if (testData[1] == "Split Sieve") // Special Case 1
                    {
                        g.DrawString(testData[0], helveticaFont, bBlack, 730 - (int)(Math.Floor(g.MeasureString(testData[0], helveticaFont).Width / 2)), table_yOffset + ((test_index + 1) * 25) + 5 + offset + additionalOffset);
                    }
                    else // Default
                    {
                        g.DrawString(testData[0], helveticaFont, bBlack, 28, table_yOffset + ((test_index + 1) * 25) + 5 + offset + additionalOffset);
                    }

                    // Special Case 1
                    if (testData[0] == "N1.23" || testData[1] == lastUpdate || testIsField)
                    {
                        if (Field)
                        {
                            string placeholder_qnt = collectedTime.ToString() + "h";
                            g.DrawString(placeholder_qnt, helveticaFont, bBlack, 585 - (int)Math.Floor(g.MeasureString(placeholder_qnt, helveticaFont).Width/2), table_yOffset + ((test_index + 1) * 25) + 5 + offset + additionalOffset);
                        }
                    }
                    // Default
                    else
                    {
                        g.DrawString("1", helveticaFont, bBlack, 580, table_yOffset + ((test_index + 1) * 25) + 5 + offset + additionalOffset);
                        g.DrawString(data["Sample.Number"], helveticaFont, bBlack, 515 - (int)Math.Floor(g.MeasureString(data["Sample.Number"], helveticaFont).Width/2), table_yOffset + ((test_index + 1) * 25) + 5 + offset + additionalOffset);
                    }


                }
                //string test_name = test_data[test_index];

                g.DrawLine(pGray, 25, (table_yOffset + 25) + ((test_index + 1) * 25) + offset + additionalOffset, pageWidth - 50, (table_yOffset + 25) + ((test_index + 1) * 25) + offset + additionalOffset);

            }
            // Box Outline
            g.DrawRectangle(pGray, new Rectangle(25, table_yOffset - 5 + offset, pageWidth - 75, (table_yOffset + 275) - (table_yOffset - 5) + additionalOffset));
            g.DrawLine(pGray, 40 + g.MeasureString("CODE", columnFont).Width, table_yOffset - 5 + offset, 40 + g.MeasureString("CODE", columnFont).Width, table_yOffset + 275 + offset + additionalOffset);
            g.DrawLine(pGray, 470, table_yOffset - 5 + offset, 470, table_yOffset + 275 + offset + additionalOffset);
            g.DrawLine(pGray, 560, table_yOffset - 5 + offset, 560, table_yOffset + 275 + offset + additionalOffset);
            g.DrawLine(pGray, 615, table_yOffset - 5 + offset, 615, table_yOffset + 275 + offset + additionalOffset);
            g.DrawLine(pGray, 685, table_yOffset - 5 + offset, 685, table_yOffset + 275 + offset + additionalOffset);

            g.DrawString("REMARKS: ________________________________________________________________________", columnFont, bBlack, 25, 480 + offset + additionalOffset);
            g.DrawString(data["Remarks"], helveticaFont, bBlack, 25 + g.MeasureString("REMARKS: ", columnFont).Width, 480 + offset + additionalOffset);
            //g.DrawString(tb_Remarks.Text, new Font("Arial", 10), bBlack, 25 + (int)g.MeasureString("REMARKS: ", columnFont).Width, 458);
            g.DrawString("REVIEWED BY: ________________________", columnFont, bBlack, pageWidth - (int)g.MeasureString("REVIEWED BY: ________________________", columnFont).Width - 50, 600 + offset + additionalOffset);

        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            DocumentPreview.Zoom += 0.15;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            DocumentPreview.Zoom -= 0.15;
        }

        private void button_exitform_Click(object sender, EventArgs e)
        {
            AdmitForm.Show();
            this.Close();
        }

        private void btnPrintDocument_Click(object sender, EventArgs e)
        {
            // Save Document
            DialogResult result = PrintDialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                // initialize PrintDocument object
                PrintDocument virtualCopy = new PrintDocument()
                {
                    PrinterSettings = new PrinterSettings()
                    {
                        // set the printer to 'Microsoft Print to PDF'
                        PrinterName = "Microsoft Print to PDF",

                        // tell the object this document will print to file
                        PrintToFile = true,

                        // set the filename to whatever you like (full path)
                        PrintFileName = Path.Combine(internalReportsDirectoryPath, string.Format("CAL{0}.pdf", data["Log.ReceiptNumber"])),
                    }
                };
                virtualCopy.PrintPage +=
                    new System.Drawing.Printing.PrintPageEventHandler(designPage);

                virtualCopy.Print();
                printDocument.Print();
            }
        }

        private void btnPromptDirectoryDialog_Click(object sender, EventArgs e)
        {
            DialogResult promptResult = FolderDialog.ShowDialog();
            if (promptResult == DialogResult.OK)
            {
                this.internalReportsDirectoryPath = FolderDialog.SelectedPath;
                btnPromptDirectoryDialog.Text = this.internalReportsDirectoryPath;
                Tooltip.SetToolTip(btnPromptDirectoryDialog, this.internalReportsDirectoryPath);
                pathsConfig["Admittance.PDF.SavePath"] = this.internalReportsDirectoryPath;
            }
        }
    }
}
