using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;


namespace SampleNote.Main.Utility
{
    public class ConfigUtility
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
                using (var buffer_reader = new StreamReader(path_configfile))
                {
                    XmlReader reader = XmlReader.Create(buffer_reader);
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
            set
            {
                //string buffer_name = Path.Combine(@"./tempbuffers/", Path.GetFileName(path_configfile));
                //File.Copy(path_configfile,  buffer_name, overwrite:true);
                XDocument doc;
                using (var buffer_reader = new StreamReader(path_configfile))
                {
                    doc = XDocument.Load(buffer_reader);

                    foreach (var add in doc.Descendants("add"))
                    {

                        // src will be null if the attribute is missing
                        
                        if (add.Attribute("key").Value == key)
                        {
                            add.SetAttributeValue("value", value);
                        }
                        
                    }
                }
                doc.Save(path_configfile);
            }
        }
    }
}
