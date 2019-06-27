using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SampleNote.Main.Utility
{
    class UTILSQL_TestCode
    {
        static SQLiteConnection databaseConnection;
        string sql;
        SQLiteCommand command;
        string database;

		public UTILSQL_TestCode()
        {
			this.database = Path.Combine(Environment.CurrentDirectory, @"database\sample_tests.codes.db");
            // Check to see if database exists
            if (!File.Exists(database))
            {
                MessageBox.Show("Missing 'sample_tests.codes.db' File.", "Missing Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            databaseConnection = new SQLiteConnection(String.Format("Data Source={0};Version=3", database));
        }

		public string[] FetchRecordWhere(string WhereParameter)
        {
            databaseConnection.Open();
            string[] Record = new string[] { };

            sql = string.Format("SELECT * FROM sample_tests WHERE {0}", WhereParameter);
            command = new SQLiteCommand(sql, databaseConnection);
            SQLiteDataReader reader = command.ExecuteReader();
			while (reader.Read())
            {
                Console.WriteLine("NCode: " + reader["NCode"] + "\tName: " + reader["TestName"] + "\tCategory: " +
                    reader["Category"]);
                Record = new string[] {
                    reader["NCode"].ToString(),
                    reader["TestName"].ToString(),
                    reader["Category"].ToString()
                };
            }
            databaseConnection.Close();
            return Record;
        }
        
        public List<string[]> FetchAllRecords()
        {
            databaseConnection.Open();
            List<string[]> Records = new List<string[]>();
            sql = "SELECT * FROM sample_tests";
            
            using (command = new SQLiteCommand(sql, databaseConnection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Records.Add(new string[]{
                            reader["NCode"].ToString(),
                            reader["TestName"].ToString(),
                            reader["Category"].ToString(),
                            reader["Nickname"].ToString()
                        });
                    }
                }
            }
            databaseConnection.Close();
            return Records;
        }

        public void setNickname(string NCode, string NName)
        {
            databaseConnection.Open();
            try
            {
                sql = string.Format("UPDATE sample_tests SET Nickname='{0}' WHERE NCode='{1}'", NName, NCode);
                command = new SQLiteCommand(sql, databaseConnection);
                command.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("SQLITE Nickname: Could not set name");
            }

            databaseConnection.Close();
        }

        public bool Append(string[] record_data)
        {
            databaseConnection.Open();
            try
            {
                sql = string.Format("INSERT INTO sample_tests (NCode, TestName, Category, Nickname) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    record_data[0],
                    record_data[1],
                    record_data[2],
                    record_data[3]);

                command = new SQLiteCommand(sql, databaseConnection);
                command.ExecuteNonQuery();

                databaseConnection.Close();
                return true;
            }
            catch
            {
                Console.WriteLine("SQLITE APPEND: Could not Execute");
            }
            databaseConnection.Close();
            return false;
        }
	       
        public List<string> GetDistinctColumn(string column_name)
        {
            databaseConnection.Open();
            List<string> ColumnData = new List<string>();
            sql = string.Format("SELECT DISTINCT {0} FROM sample_tests", column_name);
            using (command = new SQLiteCommand(sql, databaseConnection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ColumnData.Add(reader["Category"].ToString());
                    }
                }
            }
            databaseConnection.Close();
            return ColumnData;
        }

        public List<string[]> GetTestNames()
        {
            databaseConnection.Open();
            List<string[]> TestNames = new List<string[]>();
            sql = string.Format("SELECT * FROM sample_tests");
            using (command = new SQLiteCommand(sql, databaseConnection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Exception (Category is Field Test)
                        if (reader["Category"].ToString() != "Field Test")
                        {

                            if (String.IsNullOrEmpty(reader["Nickname"].ToString()))
                            {
                                TestNames.Add(new string[] { reader["TestName"].ToString() });
                            }
                            else
                            {
                                TestNames.Add(new string[] { reader["TestName"].ToString(), reader["Nickname"].ToString() });
                            }
                            
                        }

                    }
                }
            }
            databaseConnection.Close();
            return TestNames;
        }

        public List<string[]> GetFieldTests()
        {
            databaseConnection.Open();
            List<string[]> FieldTests = new List<string[]>();
            sql = string.Format("SELECT * FROM sample_tests WHERE Category='Field Test'");
            using (command = new SQLiteCommand(sql, databaseConnection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Exception (Category is Field Test)
                        FieldTests.Add(new string[] { reader["NCode"].ToString(), reader["TestName"].ToString() });
                    }
                }
            }
            databaseConnection.Close();
            return FieldTests;
        }
    }
}
