using System;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ClassLibrary1
{
    class LabelCircle : Label
    {
        public LabelCircle() { }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.AutoSize = false;

            this.Size = new Size(50, 50);//Kích thước của khung chứa text
            GraphicsPath p = new GraphicsPath(); //Khởi tạo GraphicsPath
            p.AddEllipse(0, 0, 50, 50); //Add hình elip vào GraphicsPath
            this.Region = new Region(p); //Tạo region cho label theo elip vừa add
            base.OnPaint(e);
        }

    }
}
