using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;

namespace SampleNote.Main.Utility
{
    class StringParserUtility
    {
        // Hold any Software required config files
        Utility.ConfigUtility designer = new Utility.ConfigUtility(@"./config/usercontrol.designer.config");
        Regex regex_colorParser;
        
        public StringParserUtility()
        {
            this.regex_colorParser = new Regex(designer["pattern.color.parser"]);
        }

        public Color parseColor(string color_string)
        {
            MatchCollection colorData = regex_colorParser.Matches(color_string);
            if (colorData.Count != 3)
            {
                throw new Exception("Color Parser could not match three digit values. Check config data.");
            }

            return Color.FromArgb(255,
                Int32.Parse(colorData[0].Value),
                Int32.Parse(colorData[1].Value),
                Int32.Parse(colorData[2].Value));
        }
    }
}
