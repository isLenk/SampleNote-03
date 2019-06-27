using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SampleNote.Main.Modals
{
    public partial class SQLReader : Form
    {
        Utility.UTILSQL_TestCode UTILSQL = new Utility.UTILSQL_TestCode();

        public SQLReader()
        {
            InitializeComponent();
            new Utility.HeaderUtility(Form_Header, sizable:true);
            List<string[]> Records = UTILSQL.FetchAllRecords();
            foreach (string[] record_data in Records)
            {
                DataGrid.Rows.Add(new string[] {
                    record_data[0],
                    record_data[1],
                    record_data[2]});
            }

            // Add Individual Categories to Category List
            List<string> ColumnData = UTILSQL.GetDistinctColumn("Category");
            foreach (string categoryName in ColumnData)
            {
                cbx_category.Items.Add(categoryName);
            }
        }

        private void button_exitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddRecord_Click(object sender, EventArgs e)
        {
            if (tb_Code.Text == string.Empty || tb_TestName.Text == string.Empty || cbx_category.Text == string.Empty)
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            if (UTILSQL.Append(new string[] { tb_Code.Text, tb_TestName.Text, cbx_category.Text }))
            {
                DataGrid.Rows.Add(new string[] {
                        tb_Code.Text,
                        tb_TestName.Text,
                        cbx_category.Text});
            }
            
        }
    }
}
