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
    public partial class LogDeletionConfirmation : Form
    {
        Modules.API remoteAPI; 
        public LogDeletionConfirmation(Modules.API remoteAPI, int log_index, string sample_num, Designer.MainDriver driverForm, Panel logPanel)
        {
            this.remoteAPI = remoteAPI;
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header);
            lblSampleNumber.Text = sample_num;
            btnConfirm.MouseClick += (s, e) =>
            {
                if (remoteAPI.compare_key(tbx_Password.Text))
                {
                    if (remoteAPI.delete_log(log_index))
                    {
                        MessageBox.Show("Log Deleted Successfully!");
                        driverForm.RemoveLog(logPanel);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Could not delete log");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            };

        }

        private void button_exitform_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
