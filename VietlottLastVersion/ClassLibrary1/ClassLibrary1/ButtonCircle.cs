using System;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class ButtonCircle : UserControl
    {
        public ButtonCircle() { }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.FillPie(new SolidBrush(Color.White), new Rectangle(0, 0, Width - 16, Height - 16), 0, 360);
            base.OnPaint(e);
        }
    }
}
