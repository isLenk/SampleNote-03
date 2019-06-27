using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleNote.Main.Utility
{
    class TooltipUtility
    {
        public TooltipUtility(ToolTip tooltip)
        {
            tooltip.Draw += Tooltip_Draw;
        }

        private void Tooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
        
    }
}
