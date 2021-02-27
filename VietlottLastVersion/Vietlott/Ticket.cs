using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vietlott
{
    public partial class Ticket : Form
    {
        public static DateTime now = DateTime.Now;
        public static string textTen = "";
        public static string FileName = string.Format("ThongTinMuaVe{0}.txt", now.ToString("ddMMyyyy"));
        public static string pathMuaVe = Application.StartupPath + @"\ThongTinMuaVe\";
        public static bool backLogIn;
        string ghiThongTin;

        int[] count = { 0, 0, 0, 0 }, w = { 0, 0, 0, 0 };
        ArrayList ticketA = new ArrayList(6);
        ArrayList ticketB = new ArrayList(6);
        ArrayList ticketC = new ArrayList(6);
        ArrayList ticketD = new ArrayList(6);
        ArrayList loaiVe = new ArrayList(4);

        public Ticket()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backLogIn = false;
            ghiThongTin = String.Format(pathMuaVe + FileName);
            panel1.BackColor = Color.FromArgb(231, 71, 36);
            panel3.BackColor = Color.FromArgb(231, 71, 36);
            panel5.BackColor = Color.FromArgb(231, 71, 36);
            panel7.BackColor = Color.FromArgb(231, 71, 36);
        }

        private void changeBackColor(CheckBox cb)
        {
            if (cb.Checked)
            {
                cb.BackColor = Color.Red;
            }
            else
            {
                cb.BackColor = Color.White;
            }
        }

        private int checkType(Control cb)
        {
            if (panelA.Contains(cb) || pnA.Contains(cb))
                return (int)TypeOfTicket.A;
            else if (panelB.Contains(cb) || pnB.Contains(cb))
                return (int)TypeOfTicket.B;
            else if (panelC.Contains(cb) || pnC.Contains(cb))
                return (int)TypeOfTicket.C;
            else
                return (int)TypeOfTicket.D;
        }

        private bool checkAmount(CheckBox cb)
        {
            if (cb.Checked)
                count[checkType(cb)]++;
            else //chon xong chon lai
                count[checkType(cb)]--;

            if (count[checkType(cb)] > 6)
            {
                count[checkType(cb)]--;
                cb.BackColor = Color.White;
                return false;
            }

            return true;
        }

        private void insertSelectedTicket(Control cb)
        {
            Label lb = new Label();
            ArrayList ticket = new ArrayList(6);

            switch (checkType(cb))
            {
                case (int)TypeOfTicket.A:
                    lb = labelA;
                    loaiVe.Add(0);
                    ticket = ticketA;
                    break;
                case (int)TypeOfTicket.B:
                    lb = labelB;
                    loaiVe.Add(1);
                    ticket = ticketB;
                    break;
                case (int)TypeOfTicket.C:
                    lb = labelC;
                    loaiVe.Add(2);
                    ticket = ticketC;
                    break;
                case (int)TypeOfTicket.D:
                    lb = labelD;
                    loaiVe.Add(3);
                    ticket = ticketD;
                    break;
            }

            if (cb.Name.Contains("TC"))//chon random
            {
                Random rand = new Random();
                int temp;
                int num = 46;
                ArrayList listnum = new ArrayList();
                count[checkType(cb)] = 6;

                for (int i = 0; i < num; i++)
                    listnum.Add(i);

                for (int i = 0; i < 6; i++)
                {
                    temp = rand.Next(1, listnum.Count);
                    ticket.Add(listnum[temp]);
                    listnum.RemoveAt(temp);
                }
            }
            else // tu chon tung so
            {
                int a = Convert.ToInt16(cb.Text);
                ticket.Add(a);
            }

            ticket.Sort();
            lb.Text = "";
            foreach (int i in ticket)
            {
                lb.Text += String.Format(" {0,3} ", i.ToString());
            }
        }

        private void deleteInsertedTicket(Control cb)
        {
            Label lb = new Label();
            ArrayList ticket = new ArrayList(6);

            switch (checkType(cb))
            {
                case (int)TypeOfTicket.A:
                    lb = labelA;
                    ticket = ticketA;
                    break;
                case (int)TypeOfTicket.B:
                    lb = labelB;
                    ticket = ticketB;
                    break;
                case (int)TypeOfTicket.C:
                    lb = labelC;
                    ticket = ticketC;
                    break;
                case (int)TypeOfTicket.D:
                    lb = labelD;
                    ticket = ticketD;
                    break;
            }

            if (cb.Name.Contains("HUY") || cb.Text.Contains("TC"))//chon random
            {
                RadioButton rb = (RadioButton)cb;
                Panel pn = new Panel();
                switch (checkType(rb))
                {
                    case (int)TypeOfTicket.A:
                        pn = panelA;
                        break;
                    case (int)TypeOfTicket.B:
                        pn = panelB;
                        break;
                    case (int)TypeOfTicket.C:
                        pn = panelC;
                        break;
                    case (int)TypeOfTicket.D:
                        pn = panelD;
                        break;
                }

                lb.Text = "";
                ticket.Clear();
                count[checkType(rb)] = 0;

                foreach (CheckBox check in pn.Controls)//bo checked cho checkBox
                {
                    if (check.Checked)
                    {
                        check.Checked = false;
                        changeBackColor(check);
                    }
                }

                //bo check radio Huy
                rb.Checked = false;
            }
            else
            {
                try
                {
                    int a = Convert.ToInt16(cb.Text);
                    ticket.Remove(a);

                    lb.Text = "";
                    foreach (int i in ticket)
                    {
                        lb.Text += String.Format(" {0,3} ", i.ToString());
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lỗi chọn số!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            changeBackColor(cb);
            if (cb.Checked && checkAmount(cb))
                insertSelectedTicket(cb);
            else
            {
                if (checkAmount(cb) == false)
                {
                    MessageBox.Show("Lỗi chọn số. Bạn chỉ được chọn 6 số trên 1 bảng!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                deleteInsertedTicket(cb);
            }
        }

        private void rdTCA_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked && rb.Text.Contains("TC"))
                insertSelectedTicket(rb);
            else
                deleteInsertedTicket(rb);
        }

        private void BTMua_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            bt.BackColor = Color.Goldenrod;
        }

        public void MuaVe()
        {
            try
            {
                StreamWriter writer = new StreamWriter(ghiThongTin, true);
                string veA = "", veB = "", veC = "", veD = "";
                writer.Write(textTen + "@");
                foreach (int i in loaiVe)
                {
                    switch (i)
                    {
                        case (int)TypeOfTicket.A:
                            foreach (int j in ticketA)
                            {
                                veA += j.ToString() + ",";

                            }
                            writer.Write(veA.Substring(0, veA.LastIndexOf(",")) + "/");
                            break;
                        case (int)TypeOfTicket.B:
                            foreach (int j in ticketB)
                            {
                                veB += j.ToString() + ",";
                            }
                            writer.Write(veB.Substring(0, veB.LastIndexOf(",")) + "/");
                            break;
                        case (int)TypeOfTicket.C:
                            foreach (int j in ticketC)
                            {
                                veC += j.ToString() + ",";
                            }
                            writer.Write(veC.Substring(0, veC.LastIndexOf(",")) + "/");
                            break;
                        case (int)TypeOfTicket.D:
                            foreach (int j in ticketD)
                            {
                                veD += j.ToString() + ",";
                            }
                            writer.Write(veD.Substring(0, veD.LastIndexOf(",")) + "/");
                            break;
                    }
                }
                writer.WriteLine();
                writer.Close();

                if (MessageBox.Show("Bạn đã mua vé thành công!", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch (FileLoadException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void BTMua_Click(object sender, EventArgs e)
        {
            MuaVe();
        }

        public void TroVe()
        {
            backLogIn = true;
            this.Close();
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            TroVe();
        }
        
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    MuaVe();
                    break;
                case Keys.Escape:
                    TroVe();
                    break;
            }
            return false;
        }

        private void Ticket_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(backLogIn!=true)
                Application.Exit();
        }

        private void BTMua_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            bt.BackColor = Color.Green;
        }
    }
}
