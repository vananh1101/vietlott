using System;
using System.IO;
using System.Windows.Forms;

namespace Vietlott
{
    public partial class FormTrangChu : Form
    {
        bool quaySo;
        public FormTrangChu()
        {
            LogIn.openForm = false;
            InitializeComponent();
        }

        private int checkTickets()//kt kho du lieu co du so luong nguoi mua
        {
            int countLines = 0;
            string text;
            StreamReader reader;
            try
            {
                reader = new StreamReader(Ticket.pathMuaVe+Ticket.FileName);
                do
                {
                    text = reader.ReadLine();
                    if (text != null)
                        countLines++;
                } while (text != null);

                reader.Close();
            }
            catch (FileNotFoundException)
            {
                File.Create(Ticket.pathMuaVe + Ticket.FileName);
            }
            return countLines;
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            //doc File kt du 5 dong? => Hien thi nut Ket qua
            if (checkTickets() >= 5)
                btKetQua.Visible = true;
            else
                btKetQua.Visible = false;

            quaySo = false;
        }

        private void btnLuatChoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLuatChoi f = new FormLuatChoi();
            f.ShowDialog();
            if (FormLuatChoi.openFormLC == false) { this.Show(); }
        }

        private void btnChoi_Click(object sender, EventArgs e)
        {
            LogIn.openForm = true;
            this.Close();
        }

        private void btKetQua_Click(object sender, EventArgs e)
        {
            quaySo = true;
            this.Close();

            FormQuaySo qs = new FormQuaySo();
            qs.ShowDialog();
        }

        private void FormTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LogIn.openForm == false && quaySo == false)
                if (MessageBox.Show("Bạn chắc chắn muốn thoát ứng dụng?", "Exit",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    e.Cancel = true;
        }

        private void FormTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LogIn.openForm == false && quaySo == false)
                Application.Exit();
        }
    }
}
