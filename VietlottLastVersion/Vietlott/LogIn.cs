using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vietlott
{
    public partial class LogIn : Form
    {
        public static bool openForm = false;//button "Chơi ngay"
        public static bool back = false;//quay trở về "Trang chủ"
        

        public LogIn()
        {
            FormTrangChu f = new FormTrangChu();
            f.ShowDialog();
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(200, Color.White);
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.ForeColor = Color.Black;
        }

        private void tbName_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Clear();
            tb.Focus();
        }

        private void btLogin_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.Gold;
        }

        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.Crimson;
        }

        private void CheckLogin()
        {
            try
            {
                if (tbName.Text == "" || Regex.IsMatch(tbPhone.Text, "[0-9]") == false || tbPhone.Text == ""
                    || (Regex.IsMatch(tbPhone.Text, "[0-9]") == true && tbPhone.Text.Length!=10))
                    throw new FormatException();
                else
                {
                    Ticket.textTen = tbName.Text;
                    this.Hide();

                    Ticket tk = new Ticket();
                    tk.ShowDialog();

                    if (Ticket.backLogIn)
                        this.Show();

                    tbPhone.Text = "Nhập số điện thoại của bạn...";
                    tbName.Text = "Nhập họ tên của bạn...";
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Bạn nhập sai định dạng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (back == false)
                if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Exit",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    e.Cancel = true;

        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (back == false)
                Application.Exit();
        }

        public void CheckBack()
        {
            back = true;
            if (back == true)
            {
                this.Hide();

                FormTrangChu f = new FormTrangChu();
                f.ShowDialog();
            }
            if (openForm == true)
            {
                back = false;
                this.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CheckBack();
        }
    }


    
}
