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
        string history_path = @"./background/test.log.dat"; //Path.Combine(Environment.CurrentDirectory, @"/background/test.log.dat");

        public void write(string sample_number, string modification, string date = null)
        {
            // Check to see if the date is logged
            if (date == null) {
                date = DateTime.Now.ToString("F");
            }

            string log_data = String.Format("{0}|{1}|{2}", date, sample_number, modification);
            // Read the previous data so that we can write at it again
            Byte[] orig_data = File.ReadAllBytes(history_path);
            Byte[] info =
                new UTF8Encoding(true).GetBytes(Environment.NewLine + log_data);
            
            FileStream fs = File.OpenWrite(history_path);
            fs.Write(orig_data, 0, orig_data.Length);
            fs.Write(info, 0, info.Length);
            fs.Close();
        }
    }
}
