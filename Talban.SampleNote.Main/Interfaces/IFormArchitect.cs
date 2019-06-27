using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SampleNote.Main.Interface
{
    public interface IFormArchitect
    {
        Panel CreateLog(int logIndex, bool printLabel = false);
        void RemoveLog(Panel logObject);
        void ListSizePropertyChanged();
        void ApplyListColorPattern();
        void SetTestObjectColor(Control testObject, int newTestStatus);
        void HideLogObject(Panel logObject, bool logCompleted = false, Color? overrideColor = null);

    }
}
