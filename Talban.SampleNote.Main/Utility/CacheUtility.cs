using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleNote.Main.Utility
{
    class CacheUtility
    {
        // FUTURE USE PROJECT
        string cache_folder = "./cache/";

        public CacheUtility(string cache_folder= "./cache/")
        {
            // Check if the cache folder exists, if not, make one.
            if (!File.Exists(cache_folder))
            {
                Directory.CreateDirectory(cache_folder);
            }
        }
        
        public string[] GetCacheData(string cache_filename)
        {
            // If the file does not yet exists. Return an empty string
            if (!File.Exists(Path.Combine(cache_folder, cache_filename))) 
            {
                return new string[] { };
            }
            return File.ReadAllLines(Path.Combine(cache_folder, cache_filename));
        }

        // Save the stored data into the cache folder
        public void StoreCache(string cache_file, string[] cache_data)
        {
            string file_path = Path.Combine(cache_folder, cache_file);
            // Check if the cache file exists
            if (!File.Exists(file_path))
            {
                File.Create(file_path);
            }

            File.WriteAllLines(file_path, cache_data);
        }
    }
}
