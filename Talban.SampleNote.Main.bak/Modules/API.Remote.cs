using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*
 +------------------------------------------+ 
 |                                          |
 |                                          |
 |  purp:  A remote class to access each    |
 |         api depending on what was        |
 |         selected.                        | 
 |                                          | 
 |                                          | 
 |                                          |
 +------------------------------------------+
*/


namespace SampleNote.Main.Modules
{
    public class API
    {
        dynamic chosenAPI;
        Type apiType;
        string apiString = "";

        // Decides which API is being used depending on what is passed.
        // Since SampleNote originated with Excel API. That is the default.
        public void Set_API(string api_name = "Excel API")
        {
            if (apiString == api_name)
            {
                return;
            }
            // This allows me to create various apis from google/excel when I implement it! Yess
            if (api_name == "Excel API")
            {
                Console.WriteLine("Selected Excel API");

                Assembly assemblyFile = Assembly.LoadFile(Environment.CurrentDirectory + @"/Lib/ExcelAPI.dll");
                apiType = assemblyFile.GetType("SampleNote.Main.Modules.ExcelAPI");
                
                this.chosenAPI = Activator.CreateInstance(apiType);
            }
            
        }
            
        // Pushes an update onto a Test (similar to incrementing except it pushes its status)
        // ( Idle > Start > Finish > Idle ) ret. 1 (idle) to 3 (finished) and 0 (log complete)
        public int push_teststatus(int log_index, string test_name, int overwrite_status = -1)
        {
            // "overwrite_status" Parameter allows the user to manually change it so the function
            // doesn't need to called 'x' amount of times to go to that value.
            MethodInfo push_teststatus = apiType.GetMethod("push_teststatus");
            return push_teststatus.Invoke(chosenAPI, new object[] {log_index, test_name, overwrite_status});
        }

        public Dictionary<string, string> fetch_columndata(bool inverted=false)
        {
            MethodInfo fetchColumnData = apiType.GetMethod("fetch_columndata");
            return fetchColumnData.Invoke(chosenAPI, new object[] { inverted });
        }
        // Writes a backup file and returns a bool value on its success state
        public bool write_backupfile(string file_path)
        {
            MethodInfo writeBakFile = apiType.GetMethod("write_backupfile");
            return writeBakFile.Invoke(chosenAPI, new object[] { file_path + ".bak" });
        }
        // Returns the filter string of valid extensions for the API
        public string fetch_extensions(string type="all")
        {
            MethodInfo fetchExtensions = apiType.GetMethod("fetch_extensions");
            return fetchExtensions.Invoke(chosenAPI, new object[] { type });
        }
        
        // Returns true if the log status is OK
        public bool get_logdone(int index)
        {
            MethodInfo createLog = apiType.GetMethod("get_logdone");
            return createLog.Invoke(chosenAPI, new object[] { index });
        }
        
        // Returns how many logs have been made. Rows Count - 4 (since 4 is the header offset)
        public int get_logcount()
        {
            MethodInfo getLogCount = apiType.GetMethod("get_logcount");
            return getLogCount.Invoke(chosenAPI, new object[] {});
        }

        // Returns the current sample number.
        public string pull_samplenum(int increment=0)
        {
            MethodInfo pull_samplenumber = apiType.GetMethod("pull_samplenumber");
            return pull_samplenumber.Invoke(chosenAPI, new object[] { increment });
        }

        // Modifys the current sample number.
        public string push_samplenum(int sample_index)
        {
            MethodInfo push_samplenum = apiType.GetMethod("push_samplenum");
            return push_samplenum.Invoke(chosenAPI, new object[] { sample_index });
        }

        // Returns a Dictionary list of the log data from the log index
        public Dictionary<string, string[]> fetch_log(int log_index, bool is_lognum = false)
        { 
            MethodInfo fetchLog = apiType.GetMethod("fetch_log");
            return fetchLog.Invoke(chosenAPI, new object[] { log_index, is_lognum });
        }

        // Writes log data into the last row. Returns the row index and samplenum
        public string[] create_log(Dictionary<string, string> log_data)
        {
            MethodInfo createLog = apiType.GetMethod("create_log");
            return createLog.Invoke(chosenAPI, new object[] { log_data });
        }

        // ret. "success" if successful entry, "error codes string" if not.
        public string access_file(string file_path, string protection_key)
        {
            MethodInfo accessFile = apiType.GetMethod("access_file");
            return accessFile.Invoke(chosenAPI, new object[] { file_path, protection_key });
        }

        // Formats/Produces a workable file for SampleNote to operate in.
        public void create_file(string file_path, string protection_key)
        {
            //Console.WriteLine("Creating File:", file_path, protection_key);
            MethodInfo createFile = apiType.GetMethod("create_file");
            createFile.Invoke(chosenAPI, new object[] { file_path, protection_key });
        }

        // Safely exits out of the API and tries to close the background processes that come with the API
        public void quit(bool protect = true)
        {
            MethodInfo quit = apiType.GetMethod("quit");
            quit.Invoke(chosenAPI, new object[] { protect });
        }

        // Check to see if the log already exists with the sample nubmer
        public bool check_samplelogexists(int log_index)
        {
            MethodInfo checkLogExists = apiType.GetMethod("check_samplelogexists");
            return checkLogExists.Invoke(chosenAPI, new object[] { log_index });
        }
    }
}
