using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleNote.Main.Modules
{
    class History
    {
        string history_path = Path.Combine(Environment.CurrentDirectory, @"/background/test.log.dat");

        public void write(string sample_number, string modification, string date = null)
        {
            // Check to see if the date is logged
            if (date == null) {
                date = DateTime.Now.ToString("F");
            }

            string log_data = String.Format("{0}|{1}|{2}", date, sample_number, modification);
            Byte[] info =
                new UTF8Encoding(true).GetBytes(log_data);
            FileStream fs = File.OpenWrite(@"./background/test.log.dat");
            fs.Write(info, 0, info.Length);
            fs.Close();
        }
    }
}
