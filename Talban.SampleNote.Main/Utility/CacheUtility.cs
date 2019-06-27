using System.IO;

namespace SampleNote.Main.Utility
{
    class CacheUtility
    {
        // FUTURE USE PROJECT
        string cacheDirectory = "./cache/";

        public CacheUtility(string cacheDirectory = "./cache/")
        {
            // Check if the cache folder exists, if not, make one.
            if (!File.Exists(cacheDirectory))
            {
                Directory.CreateDirectory(cacheDirectory);
            }
        }
        
        public string[] GetCacheData(string cacheFileName)
        {
            // If the file does not yet exists. Return an empty string
            if (!File.Exists(Path.Combine(cacheDirectory, cacheFileName))) 
            {
                return new string[] { };
            }
            return File.ReadAllLines(Path.Combine(cacheDirectory, cacheFileName));
        }

        // Save the stored data into the cache folder
        public void StoreCache(string cacheFile, string[] cacheData)
        {
            string filePath = Path.Combine(cacheDirectory, cacheFile);
            // Check if the cache file exists
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            File.WriteAllLines(filePath, cacheData);
        }
    }
}
