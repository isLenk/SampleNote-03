using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SampleNote.Main.Modules
{
    public class SQLiteAPI
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
//            {"Admittance Num.",     "L" },
            {"Tests Required",      "L" },
            {"Status",              "M" }
        };

        string sample_indexformat = "L{0:D4}";
        int current_sampleindex;

        static SQLiteConnection databaseConnection;
        string sql;
        SQLiteCommand command;
        string database;
        string protection_key;
        string file_extensions = "SQLite Database|*.db";
        string bak_extensions = ".db";

        public SQLiteAPI()
        {
            Console.WriteLine("SQLite API Constructed");
        }

        public string access_file(string file_path, string protection_key)
        {
            this.protection_key = protection_key;
            databaseConnection = new SQLiteConnection(String.Format("Data Source={0};Password={1};Version=3", file_path, protection_key));
            Console.WriteLine("Loading Database");
            databaseConnection.Open();
            return "success";
        }

        public void create_file(string file_path, string protection_key)
        {
            SQLiteConnection.CreateFile(file_path);
            databaseConnection = new SQLiteConnection(String.Format("Data Source={0};Version=3", file_path));
            databaseConnection.SetPassword(protection_key);
            databaseConnection.Open();

            sql = "CREATE TABLE LogData (Log Number INT PRIMARY KEY,";
            foreach (string column_name in sample_columndata.Keys)
            {
                if (sample_columndata[column_name] == sample_columndata["Status"])
                {
                    sql += column_name.Replace(" ", "_").Replace(".","0") + " varchar(255)";
                }
                else
                {
                    sql += column_name.Replace(" ", "_").Replace(".", "0") + " varchar(255),";
                }
            }
            
            sql += ")";
            Console.WriteLine(sql);
            command = new SQLiteCommand(sql, databaseConnection);
            command.ExecuteNonQuery();
        }

        public string[] create_log(Dictionary<string, string> log_data)
        {
            throw new NotImplementedException("Welp");
            //Console.WriteLine("Create Log > Log Request Invoked");

            //return string[];
        }

        public string pull_samplenumber(int increment = 0)
        {
            return String.Format(sample_indexformat, current_sampleindex + increment);
        }

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

        public string fetch_extensions(string type = "all")
        {
            if (type == "bak")
            {
                return bak_extensions;
            }
            return file_extensions;
        }

        public int get_logcount()
        {
            sql = "SELECT COUNT(*) FROM LogData";
            command = new SQLiteCommand(sql, databaseConnection);
            
            Int32 logCount = Int32.Parse(command.ExecuteScalar().ToString());
            Console.WriteLine(logCount);

            return logCount;
        }
    }
}
