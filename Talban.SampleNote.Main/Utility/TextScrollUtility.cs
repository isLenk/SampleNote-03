using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleNote.Main.Utility
{
    class TextScrollUtility
    {

        public void Add(Label label, int inc=-1)
        {
            int lastWidth = label.Width;
            string text = label.Text;
            string textBackup = label.Text;
            if (TextRenderer.MeasureText(label.Text, label.Font).Width + 3 < label.Width)
            {
                return;
            }
            if (inc == -1) // Set to width
            {
                string charactersPermitted = label.Text;
                // Repeat process until characters in textbox can fit properly
                while (TextRenderer.MeasureText(charactersPermitted, label.Font).Width > label.Width)
                {
                    charactersPermitted = charactersPermitted.Substring(1);
                }
                inc = charactersPermitted.Length;
            }
            try
            {
                text.Substring(0, inc);
            }
            catch
            {
                return;
            }

            Timer oTimer = new Timer();


            int currentRow = 0;
            int cInc = inc;
            oTimer.Tick += (s, e) =>
            {
                if (label.Width != lastWidth)
                {
                    oTimer.Stop();
                    label.Text = textBackup; // Return original text
                    Console.WriteLine(label.Text);
                    oTimer.Dispose();
                    return;
                }
                string start = text.Substring(currentRow, cInc);
                currentRow++;
                label.Text = start;
                if (currentRow + cInc > text.Length)
                {
                    cInc--;
                }
                if (cInc == 0)
                {
                    currentRow = 0;
                    cInc = inc;
                }
            };

            oTimer.Interval = 350;
            oTimer.Start();
        }
    }
}
