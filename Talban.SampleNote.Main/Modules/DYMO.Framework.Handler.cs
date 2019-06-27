using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SampleNote.Main.Modules
{
    class DYMO_LabelWriter
    {
        string printerName = "DYMO LabelWriter DUO Label";

        public void PrintLabel(Dictionary<string, string[]> logData)
        {
			// Check to see if the printer is connected to the device
            if (!DYMO.Label.Framework.Framework.GetLabelWriterPrinters().Contains(printerName))
            {
				// Display error message
                MessageBox.Show(String.Format("Missing LabelWriter Printer '{0}'. Check to see if it is properly plugged in", printerName), "DYMO LabelWriter Printer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			// Load the template label for the print
            var label = DYMO.Label.Framework.Label.Open(Path.Combine(Environment.CurrentDirectory, "/config/PrintTag.label"));
            // Append all the lists of tests into this string which will then be put into the last label
            string List_Of_Tests = "";
			// Read the tests required and format it similar to "- Test
            foreach (string testName in logData["Tests Required"])
            {
                if (String.IsNullOrEmpty(testName))
                {
                    break;
                }
                List_Of_Tests += string.Format("- {0}\n", testName);
            }

            label.SetObjectText("LABEL_SAMPLENUMBER", logData["Sample Number"][0]);
            label.SetObjectText("LABEL_PROJECTNUMBER", logData["Project Number"][0]);
            label.SetObjectText("LABEL_PROJECTNAME", logData["Project Name"][0]);
            label.SetObjectText("LABEL_CLIENT", logData["Client Name"][0]);
            label.SetObjectText("LABEL_TESTLIST", List_Of_Tests);
                            
            label.Print(printerName);
        }
    }
}
