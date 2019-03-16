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
    public partial class Control_Designer : Form
    {
        public Control_Designer()
        {
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header);
        }

        private void button_exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
