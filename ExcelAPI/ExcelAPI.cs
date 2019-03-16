using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

// CLASS SHOULD ONLY BE CALLED BY REMOTE API
/*
 *  LANCES EXCEL API SAMPLENOTE LIBRARY
 *  TO ONLY BE USED WITH SAMPLENOTE
 *  USED BY THE REMOTE API CLASS
 *  FEBRUARY 26, 2019
*/
namespace SampleNote.Main.Modules
{
    public class ExcelAPI
    {
        Dictionary<string, string> sample_columndata = new Dictionary<string, string>()
        {
            {"Sample Number",       "A"},
            {"Project Number",      "B" },
            {"Project Name",        "C" },
            {"Project Location",    "D" },
            {"Client Name",         "E" },
            {"Date Recieved",       "F" },
            {"Samp. Description",   "G" },
            {"Samp. Location",      "H" },
            {"Supplied By",         "I" },
            {"Sampled By",          "J" },
            {"Admitted By",         "K" },
            {"Admittance Num.",     "L" },
            {"Tests Required",      "M" },
            {"Status",              "X" }
        };
        static _Application excelApp;
        static Workbook workbook;
        static Worksheet worksheet;
        string protection_key;
        int current_sampleindex;
        string sample_indexformat = "L{0:D4}";
        string file_extensions = "Excel Workbook|*.xlsx|Excel Macro-Enabled Workbook|*.xlsm";
        string bak_extensions = ".xlsx";
        Color color_idle = Color.FromArgb(255, 0, 0, 0);
        Color color_started = Color.FromArgb(255, 20, 255, 120);
        Color color_finished = Color.FromArgb(255, 220, 25, 25);
        Color color_logDone = Color.FromArgb(255, 130, 255, 95);

        public ExcelAPI()
        {
            Console.WriteLine("Excel API Constructed");
            excelApp = new Application();
        }

        /*  ---------------- RETURN ---------------------- */
        // Returns the column data
        public Dictionary<string, string> fetch_columndata(bool inverted = false)
        {
            if (inverted)
            {
                Dictionary<string, string> inverted_columndata = new Dictionary<string, string>();
                
                foreach (string key in sample_columndata.Keys)
                {
                    inverted_columndata.Add(sample_columndata[key], key);
                }
                return inverted_columndata;
            }
            return sample_columndata;
        }
        // Returns all the extensions allowed for this API
        public string fetch_extensions(string type = "all")
        {
             if (type == "bak")
            {
                return bak_extensions;
            }

            return file_extensions;
        }

        // Produce a backup file
        public bool write_backupfile(string file_path)
        {
            try
            {
                Console.WriteLine("Creating Backup: " + file_path);
                workbook.SaveCopyAs(file_path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Returns the number of logs there are
        public int get_logcount()
        {
            // 4 is the offset range
            return worksheet.UsedRange.Rows.Count - 4;
        }

        // Safely exit from worksheet and workbook
        public void quit(bool protectDocument = true)
        {
            if (protectDocument)
            {
                protect();
            }
            else
            {
                unprotect();
            }
            save();


            workbook.Close(true);
            excelApp.Quit();
            Marshal.FinalReleaseComObject(worksheet);
            Marshal.FinalReleaseComObject(workbook);
            Marshal.FinalReleaseComObject(excelApp);
        }

        // Returns the current sample number
        public string pull_samplenumber(int increment = 0)
        {
            return String.Format(sample_indexformat, current_sampleindex + increment);
        }
        
        // Edits the current sample number
        public string push_samplenum(int new_sample_index)
        {
            this.current_sampleindex = new_sample_index;
            return String.Format(sample_indexformat, current_sampleindex);
        }

        // Checks to see if there is a log with the same sample number
        public bool check_samplelogexists(int log_index)
        {
            string log_number = String.Format(sample_indexformat, log_index);
            for (int index = 4; index < worksheet.UsedRange.Rows.Count; index++)
            {
                if (worksheet.Range[sample_columndata["Sample Number"]+index].Value != null)
                {
                    if (worksheet.Range[sample_columndata["Sample Number"] + index].Value == log_number)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Fetches log data from the index
        public Dictionary<string, string[]> fetch_log(int index, bool is_lognum = false)
        {
            // Check to see if the index value is a log number. If not increment index by offset (def: +4)
            if (is_lognum)
            {
                string formatted_index = String.Format(sample_indexformat, index);
                // Search all rows for a sample number the same as the index
                for (int rowIndex = 4; rowIndex < worksheet.UsedRange.Rows.Count; rowIndex++)
                {
                    // Compare row index to formatted index value
                    if (worksheet.Range[sample_columndata["Sample Number"] + rowIndex].Value == formatted_index)
                    {
                        index = rowIndex;
                    }
                }
            }
            else
            {
                index += 4;
            }
            Dictionary<string, string[]> logData = new Dictionary<string, string[]>();
            Console.WriteLine("Fetching Log Data #" + index.ToString());
            foreach (string key in sample_columndata.Keys)
            {
                string column_letter = sample_columndata[key];
                if (key == "Tests Required") // M = 13, 
                {
                    string[] tests_recorded = new string[10];
                    for (int test_index = 0; test_index < 10; test_index++)
                    {
                        Range cell_data = worksheet.Cells[index, test_index + 13];
                        if (String.IsNullOrEmpty(cell_data.Value))
                        {
                            break;
                        }
                        // Status+TestName (1Talban)

                        tests_recorded[test_index] = get_cellStat_fromColor(cell_data.Font.Color).ToString() + cell_data.Value;
                    }
                    logData.Add(key, tests_recorded);
                }
                else if (key == "Date Recieved")
                {
                    if (worksheet.Range[column_letter + index.ToString()].Value2 != null)
                    {
                        logData.Add(key, new string[] { worksheet.Range[column_letter + index.ToString()].Value.ToString().Substring(1) });
                    }
                    else
                    {
                        logData.Add(key, new string[] { "Not Provided" });
                    }
                }
                else
                {
                    if (worksheet.Range[column_letter + index.ToString()].Value != null)
                    {
                        logData.Add(key, new string[] { worksheet.Range[column_letter + index.ToString()].Value.ToString() });
                    }
                }
            }
            return logData;
        }

        // Checks to see if the log is completed
        public bool get_logdone(int index)
        {
            index += 4;
            double cell_color = worksheet.Range[sample_columndata["Status"] + index.ToString()].Interior.Color;
            if (cell_color == 6291330)
            {
                return true;
            }
            return false;
        }

        // Creates a log using the log data parameter
        public string[] create_log(Dictionary<string, string> log_data)
        {
            Console.WriteLine("Create Log > Log Request Invoked");

            if (worksheet == null)
            {
                Console.WriteLine("Throwing Excel Exception");
                throw new Exception("Worksheet does not exist!");
            }

            string currentRange = (worksheet.UsedRange.Rows.Count + 1).ToString();

            Regex regex = new Regex(@"[^/./]+");
            // PATTERN: [/./]
            foreach (string logkey in log_data.Keys)
            {
                string logElement = log_data[logkey];

                if (logkey == sample_columndata["Tests Required"]) // M = 13, 
                {
                    MatchCollection matches = regex.Matches(logElement);

                    for (int index = 0; index < matches.Count; index++)
                    {
                        worksheet.Cells[currentRange, index + 13].Value = matches[index].Value;
                    }

                }
                else if (logkey == sample_columndata["Date Recieved"])
                {
                    worksheet.Range[logkey + currentRange].Value2 = "." + logElement;
                }
                else
                {
                    worksheet.Range[logkey + currentRange].Value = logElement;
                }
            }

            worksheet.Range[sample_columndata["Sample Number"] + currentRange].Value = String.Format(sample_indexformat, current_sampleindex);

            try
            {
                current_sampleindex += 1;
                Console.WriteLine("Create Log > Attempting to save excel document");
                if (!workbook.Saved)
                {
                    workbook.Save();
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Unable to save to Excel File!");
                return new string[] { "0" };
            }
            return new string[] { (Int32.Parse(currentRange) - 4).ToString(), String.Format(sample_indexformat, current_sampleindex) };
        }

        // Push Test Status. Returns int from 0-3
        public int push_teststatus(int log_index, string test_name, int overwrite_status = -1)
        {
            // Add offset
            log_index += 4;

            // Check each log to see if it has a value of three
            bool sample_completed = true;
            int newTestState = 1;

            void testElevationHandler(Range cell_data)
            {

                switch (overwrite_status)
                {
                    case 1:
                        {
                            cell_data.Font.Color = color_idle;
                            newTestState = 1;
                            cell_data.Font.Strikethrough = false;
                            sample_completed = false;
                            break;
                        }
                    case 2:
                        {
                            cell_data.Font.Color = color_started;
                            newTestState = 2;
                            sample_completed = false;
                            break;
                        }
                    case 3:
                        {
                            cell_data.Font.Color = color_finished;
                            cell_data.Font.Strikethrough = true;
                            newTestState = 3;
                            break;
                        }

                }
            }

            // Loop through test indexes 1 through 10 and add the +13 offset
            for (int test_index = 0; test_index < 10; test_index++)
            {
                Range cell_data = worksheet.Cells[log_index, 13 + test_index];
                double cell_color = cell_data.Font.Color;

                // If the cell_data for some reason is null, then break out of loop.
                if (cell_data.Value == null)
                {
                    break;
                }

                // Only one Test
                if (test_index == 0 && worksheet.Cells[log_index, 14].Value == null)
                {
                    // Check to see for overwrite value
                    if (overwrite_status != -1)
                    {
                        Console.WriteLine("Modifying Test Data");
                        testElevationHandler(cell_data);
                        break;
                    }
                    
                    if (get_cellStat_fromColor(cell_color) == 2)
                    {
                        cell_data.Font.Color = color_finished;
                        cell_data.Font.Strikethrough = true;
                        sample_completed = true;
                        newTestState = 3;
                    }
                    else if (get_cellStat_fromColor(cell_color) == 1)
                    {
                        sample_completed = false;
                        cell_data.Font.Color = color_started;
                        cell_data.Font.Strikethrough = false;
                        newTestState = 2;
                    }
                    else
                    {
                        sample_completed = false;
                        cell_data.Font.Color = color_idle;
                        cell_data.Font.Strikethrough = false;
                        newTestState = 1;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("PAAPAPA");
                    // Test that is not the current one
                    if (cell_data.Value.ToString() != test_name &&
                        get_cellStat_fromColor(cell_color) != 3)
                    {
                        sample_completed = false;
                    }
                    // Check test if it is the same one
                    else if (cell_data.Value.ToString() == test_name)
                    {

                        if (overwrite_status == -1)
                        {
                            // Test Idle to Started
                            if (cell_color == 0)
                            {
                                cell_data.Font.Color = color_started;
                                newTestState = 2;
                            }
                            // Test Started to Finished
                            else if (cell_color == 7929620)
                            {
                                cell_data.Font.Color = color_finished;
                                cell_data.Font.Strikethrough = true;
                                newTestState = 3;
                            }
                            // Test Finished to Idle
                            else //(cell_color == 1376120)
                            {
                                cell_data.Font.Color = color_idle;
                                cell_data.Font.Strikethrough = false;
                                newTestState = 1;
                            }
                        }
                        else
                        {
                            testElevationHandler(cell_data);
                        }
                    }
                }
            }
            if (sample_completed)
            {
                worksheet.Range[sample_columndata["Status"] + log_index.ToString()].Interior.Color = color_logDone;
                save();
                return 0;
            }
            save();
            return newTestState;
        }

        // Attempts to access an excel file using the protection key. Returns true if OK, else false
        public string access_file(string file_path, string protection_key)
        {
            this.protection_key = protection_key;
            Console.WriteLine("Loading Workbook");
            excelApp = new Application();
            workbook = excelApp.Workbooks.Open(Filename: file_path, ReadOnly: false);
            worksheet = workbook.ActiveSheet;
            /*
            Console.WriteLine(worksheet.ProtectionMode);
            Console.WriteLine(worksheet.ProtectContents);
            Console.WriteLine(worksheet.ProtectDrawingObjects);
            Console.WriteLine(worksheet.ProtectScenarios);
            */
            if (workbook.ReadOnly)
            {
                workbook.Close();
                excelApp.Quit();
                Marshal.FinalReleaseComObject(workbook);
                Marshal.FinalReleaseComObject(excelApp);
                return String.Format("{0}{1}\"{2}\"",
                    "Workbook is Read-Only. Potential background Excel Processes are running. " +
                    "Try to close them. You can use the cmd prompt and enter: ", Environment.NewLine,
                    "taskkill /F /IM EXCEL.exe");
            }
            try
            {
                unprotect();
                Console.WriteLine("Access Function > Protection Test Successful");
                prep_samplenumber();
                return "success";
            }
            catch
            {
                workbook.Close();
                excelApp.Quit();
                Marshal.FinalReleaseComObject(workbook);
                Marshal.FinalReleaseComObject(excelApp);
                Console.WriteLine("Access Function > Invalid Password");
                return "Password Invalid!";
            }
        }

        // Generates a custom SampleNote Excel File
        public void create_file(string file_path, string protection_key)
        {
            this.protection_key = protection_key;
            Console.WriteLine("Creating new workbook");
            workbook = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            worksheet = workbook.ActiveSheet;

            worksheet.Columns.ColumnWidth = 17;

            Range header = worksheet.Range["A1:X3"];
            header.Merge();
            header.Value = "SampleNote Auto Generated Format: Avoid Modifying the cells.";
            header.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            header.Interior.Color = Color.FromArgb(255, 34, 43, 53);
            header.Font.Color = XlRgbColor.rgbWhite;

            Range column_headers = worksheet.Range["A4:X4"];
            column_headers.Interior.Color = Color.FromArgb(255, 51, 63, 79);
            column_headers.Font.Color = XlRgbColor.rgbWhite;
            column_headers.RowHeight = 25;
            column_headers.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            worksheet.Range[sample_columndata["Tests Required"] + "4:W4"].Merge();


            foreach (string column_key in sample_columndata.Keys)
            {
                worksheet.Range[sample_columndata[column_key] + '4'].Value = column_key;
            }
            prep_samplenumber();
            workbook.SaveAs(file_path, XlFileFormat.xlOpenXMLWorkbook);
        }
        
        /* ---------------- VOID ---------------------- */
        // Protect the worksheet and workbook file w/ protectionKey
        private void protect()
        {
            Console.WriteLine("Protecting Document");
            workbook.Protect(this.protection_key);
            worksheet.Protect(this.protection_key);
        }

        // Unprotect the worksheet and workbook file w/ protectionKey
        private void unprotect()
        {
            Console.WriteLine("Unprotecting Document");
            workbook.Protect(this.protection_key);
            worksheet.Unprotect(this.protection_key);
        }

        // Save the worksheet w/out protecting it
        private void save()
        {
            Console.WriteLine("Saving Document");
            workbook.Save();
        }

        private void prep_samplenumber()
        {
            int lastRow = worksheet.UsedRange.Rows.Count;
            Range last_samplenumRange = worksheet.Range[sample_columndata["Sample Number"] + lastRow];
            if (last_samplenumRange.Value == null)
            {
                Console.WriteLine("Last Range is invalid!");
                current_sampleindex = 0;
                return;
            }

            Console.WriteLine("Setting Sample Index");
            int samplenum_index;
            bool isNumeric = int.TryParse(last_samplenumRange.Value.ToString().Substring(1), out samplenum_index);
            if (isNumeric)
            {
                current_sampleindex = samplenum_index;
                return;
            }

            current_sampleindex = 0;
        }

        // Retrieves an int from range
        private int get_cellStat_fromColor(double cell_color)
        {
                // Idle
                if (cell_color == 0)
                {
                    return 1;
                }
                // Started
                else if (cell_color == 7929620)
                {
                    return 2;
                }
                // Finished
                else if (cell_color == 1645020)
                {
                    return 3;
                }
                // Default to Idle
                else
                {
                    return 1;
                }
            }
    }
}
