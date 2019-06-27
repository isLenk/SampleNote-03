using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SampleNote.Main.Utility
{
    class TweenUtility
    {
        public void TweenSize(object obj, Point goalPosition, int intervalRate = 1, int incrementRate = 5)
        {
            dynamic tweenObject = null;

            if (obj is Panel)
            {
                tweenObject = obj as Panel; 
            }

            if (tweenObject == null)
            {
                return;
            }

            string xChange = "";
            string yChange = "";

            Timer tweenTimer = new Timer();
            tweenTimer.Enabled = true;
            tweenTimer.Interval = intervalRate;
            tweenTimer.Tick += (s, e) =>
            {
                // Decrease Height
                if (tweenObject.Height > goalPosition.Y && yChange != "increase")
                {
                    if (yChange == "") { yChange = "decrease"; }
                    tweenObject.Height -= incrementRate;
                    if (tweenObject.Height <= goalPosition.Y)
                    {
                        tweenObject.Height = goalPosition.Y;
                        tweenTimer.Stop();
                        tweenTimer.Dispose();
                    }
                }

                // Increase Height
                if (tweenObject.Height < goalPosition.Y && yChange != "decrease")
                {
                    if (yChange == "") { yChange = "increase"; }
                    tweenObject.Height += incrementRate;
                    if (tweenObject.Height > goalPosition.Y)
                    {
                        tweenObject.Height = goalPosition.Y;
                        tweenTimer.Stop();
                        tweenTimer.Dispose();
                    }
                }

                // Decrease Width
                if (tweenObject.Width > goalPosition.X && xChange != "increase")
                {
                    
                    if (xChange == "") { xChange = "decrease"; }
                    tweenObject.Width -= incrementRate;
                    if (tweenObject.Width <= goalPosition.X)
                    {
                        tweenObject.Width = goalPosition.X;
                        tweenTimer.Stop();
                        tweenTimer.Dispose();
                    }
                }

                // Increase Width
                if (tweenObject.Width < goalPosition.X && xChange != "decrease")
                {
                    if (xChange == "") { xChange = "increase"; }
                    tweenObject.Width += incrementRate;
                    if (tweenObject.Width > goalPosition.X)
                    {
                        tweenObject.Width = goalPosition.X;
                        tweenTimer.Stop();
                        tweenTimer.Dispose();
                    }
                }
            };

            
        }
    }
}
