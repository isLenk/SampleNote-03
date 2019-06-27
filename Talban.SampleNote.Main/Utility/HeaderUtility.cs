using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SampleNote.Main.Utility
{
    public class HeaderUtility
    {
        Form form_object;
        Panel header_object;
        bool dragging = false;
        bool sizable = false;
        bool canHideHeader = false;
        bool lockedHeader = false;
        int origin_offsetX = 0;
        int origin_offsetY = 0;
        int normalHeight = 0;
        int minimizedHeaderSize = 5;


        public HeaderUtility(Panel header, bool sizable = false, bool canHideHeader = false)
        {
            header_object = header;
            form_object = header.FindForm();
            this.sizable = sizable;
            this.canHideHeader = canHideHeader;
            this.normalHeight = header.Height;
            header.MouseDown += Header_MouseDown;
            header.MouseUp += Header_MouseUp;
            header.MouseMove += Header_MouseMove;
            header.DoubleClick += Header_DoubleClick;
            // For hiding header
            
            if (canHideHeader)
            {
                header.MouseEnter += Header_MouseEnter;
                header.MouseLeave += Header_MouseLeave;
                header.MouseClick += Header_MouseClick;
                form_object.SizeChanged += Header_SizeChanged;
            }
        }
        
        private void Header_MouseClick(object sender, MouseEventArgs e)
        {
            // User right clicked header, lock
            if (e.Button == MouseButtons.Right)
            {
                lockedHeader = !lockedHeader;
                
            }
        }

        private void Header_SizeChanged(object sender, EventArgs e)
        {
            if (form_object.WindowState == FormWindowState.Maximized)
            {
                if (!lockedHeader)
                {
                    header_object.Height = minimizedHeaderSize;
                    return;
                }
            }
            header_object.Height = normalHeight;            
        }

        private void Header_MouseEnter(object sender, EventArgs e)
        {
            header_object.Height = normalHeight;
        }

        bool timerInPlace = false;
        private void Header_MouseLeave(object sender, EventArgs e)
        {
            // Prevents multiple calls in case they use sub objects inside header
            if (timerInPlace)
            {
                return;
            }

            if (form_object.WindowState != FormWindowState.Maximized)
            {
                return;
            }
            timerInPlace = true;
            Timer timer = new Timer();
            timer.Interval = 150;
            timer.Enabled = true;
            timer.Tick += (s, _) =>
            {
                if (Cursor.Position.Y > header_object.Height)
                {
                    timer.Enabled = false;
                    timer.Dispose();
                    if (!lockedHeader)
                    {
                        header_object.Height = minimizedHeaderSize;
                    }
                    timerInPlace = false;
                }
            };
            
        }

        FormWindowState window_state;

        private void Header_DoubleClick(object sender, EventArgs e)
        {
            if (sizable)
            {
                if (form_object.WindowState == FormWindowState.Normal)
                {
                    window_state = FormWindowState.Maximized;
                }
                else
                {
                    window_state = FormWindowState.Normal;
                }

            }
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                int newX = Cursor.Position.X - origin_offsetX;
                int newY = Cursor.Position.Y - origin_offsetY;
                form_object.Location = new Point(newX, newY);
                if (sizable)
                {
                    if (Cursor.Position.Y == Screen.FromControl(form_object).Bounds.Top)
                    {
                        window_state = FormWindowState.Maximized;
                    }
                    else
                    {
                        window_state = FormWindowState.Normal;
                        if (form_object.WindowState != window_state)
                        {
                            form_object.WindowState = window_state;
                        }
                        
                    }
                }
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            form_object.Opacity = 1;
            if (sizable)
            {
                form_object.WindowState = window_state;
            }
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (form_object.WindowState == FormWindowState.Maximized)
            {
                return;
            }
            dragging = true;
            form_object.Opacity = .85;
            origin_offsetX = Cursor.Position.X - form_object.Left;
            origin_offsetY = Cursor.Position.Y - form_object.Top;
            
        }
    }
}
