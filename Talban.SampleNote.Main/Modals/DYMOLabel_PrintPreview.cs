using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleNote.Main.Modals
{
    public partial class DYMOLabel_PrintPreview : Form
    {

        Modules.DYMOLabelWriter DymoLabelWriter = new Modules.DYMOLabelWriter();
        int printQuantity = 1;
        Dictionary<string, string[]> logData;
        public DYMOLabel_PrintPreview(Dictionary<string, string[]> logData)
        {
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header);
            this.logData = logData;
            LABEL_LProjectName.Text = logData["Project Name"][0];
            LABEL_LProjectNumber.Text = logData["Project Number"][0];
            LABEL_LClient.Text = logData["Client Name"][0];
            LABEL_LSampleNumber.Text = logData["Sample Number"][0];
            foreach (string test in logData["Tests Required"])
            {
                if (string.IsNullOrEmpty(test))
                {
                    break;
                }
                LABEL_LTestsRequiredList.Text += string.Format("- {0}{1}", test.Substring(1), Environment.NewLine);
            }

            btnAdd.MouseClick += (s, e) =>
            {
                printQuantity += 1;
                lblQuantity.Text = printQuantity.ToString();
            };

            btnSubtract.MouseClick += (s, e) =>
            {
                printQuantity -= 1;

                // Ternary Operator: Assign value to 1 if it is below it.
                printQuantity = printQuantity <= 0 ? 1 : printQuantity; 

                lblQuantity.Text = printQuantity.ToString();
            };
            
        }

        private void button_exitform_Click(object sender, EventArgs e) { this.Dispose(); }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dialogData = MessageBox.Show(string.Format("Proceed printing {0} copies?", printQuantity), 
                "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogData == DialogResult.No)
            {
                return;
            }

            // Invoke function (#Quantity) amount of times
            for (int copy = 0; copy < printQuantity; copy++) { DymoLabelWriter.PrintLabel(logData); }
            printQuantity = 1;
        }
    }
}
