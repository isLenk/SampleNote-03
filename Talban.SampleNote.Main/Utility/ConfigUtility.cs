using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace SampleNote.Main.Utility
{
    class ConfigUtility
    {
        string path_configfile;
        public ConfigUtility(string path_configfile)
        {
            if (!File.Exists(path_configfile))
            {
                throw new FileNotFoundException("File does not exist! Missing: " + path_configfile);
            }

            this.path_configfile = path_configfile;
            Console.WriteLine(String.Format("Config Class Constructed for {0}", path_configfile));
        }

        public string this[string key]
        {
            get
            {
                XmlReader reader = XmlReader.Create(path_configfile);
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.HasAttributes)
                    {
                        if (reader.GetAttribute("key") == key)
                        {
                            return reader.GetAttribute("value");
                        }
                    }
                }
                return "Error";
            }
            
        }
    }
}
