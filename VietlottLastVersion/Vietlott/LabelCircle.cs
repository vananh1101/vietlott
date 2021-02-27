using System;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vietlott
{
    class LabelCircle : Label
    {
        public LabelCircle() { }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.AutoSize = false;
            this.ForeColor = Color.White; //màu chữ
            this.TextAlign = ContentAlignment.MiddleCenter; //canh vị trí label
            this.BackColor = Color.FromArgb(208, 1, 27); //màu nền
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Size = new Size(60, 60);//Kích thước của khung chứa text
            GraphicsPath p = new GraphicsPath(); //Khởi tạo GraphicsPath
            p.AddEllipse(0, 0, 60, 60); //Add hình elip vào GraphicsPath
            this.Region = new Region(p); //Tạo region cho label theo elip vừa add
            base.OnPaint(e);
        }
    } 
    }
