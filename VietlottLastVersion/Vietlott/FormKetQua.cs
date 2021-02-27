using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vietlott
{
    public partial class FormKetQua : Form
    {
        int countGiaiNhat = 0, countGiaiNhi = 0, countGiaiBa = 0, countJackPot = 0, countSoTrung = 0;
        public static ArrayList dsKQSo = new ArrayList(6);
        string pathKetQua;
        double jackPot = 3000000000;
        string filePath;

        public FormKetQua()
        {
            InitializeComponent();
        }

        private void FormKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormKetQua_Load(object sender, EventArgs e)
        {
            pathKetQua = Application.StartupPath + @"\ThongTinKetQua\";
            filePath = String.Format(pathKetQua + @"KetQua{0}.txt", Ticket.now.ToString("ddMMyyyy"));
            khoiTaoControl();
            khoiTaoKQ();
            docFile();
            docFileKetQua(filePath);
        }

        private void khoiTaoControl()
        {
            jackPot = giaTriJackpot();
            this.lbNgayThangXo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbNgayThangXo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbNgayThangXo.Location = new System.Drawing.Point(30, 120);
            this.lbNgayThangXo.Name = "lbNgayThangXo";
            this.lbNgayThangXo.Size = new System.Drawing.Size(495, 100);
            this.lbNgayThangXo.TabIndex = 1;
            this.lbNgayThangXo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lbNgayThangXo.Text = String.Format("Kết quả quay số mở thưởng MEGA 6/45\r\r\n" +
                    "Kỳ quay thưởng ngày {0}",
                     Ticket.now.ToString("dd/MM/yyyy"));
            panel2.Controls.Add(lbNgayThangXo);
            lbGiatriJackpot.Text = String.Format("{0:#,##0} VND", jackPot);
            lbTienGiaiJackpot.Text = String.Format("{0:#,##0}", jackPot);
            lbGiaiNhi.Text = lbGiaiNhat.Text = lbGiaiBa.Text = lbJackpot.Text = "0";

        }

        private double giaTriJackpot()
        {
            bool kq = ktJackpot();
            if (kq == true)
            {
                jackPot += 1000000000;
            }
            else
                jackPot = 3000000000;
            return jackPot;
        }

        private bool ktJackpot()
        {
            string kq = string.Format(pathKetQua + "KetQua{0}.txt", Ticket.now.AddDays(-1).ToString("ddMMyyyy"));
            bool kt = false;
            docFileKetQua(kq);
            if (lbJackpot.Text.Equals("0"))
            {
                kt = true;
            }
            return kt;
        }

        private void khoiTaoKQ()
        {
            dsKQSo.Sort();
            labelCircle1.Text = dsKQSo[0].ToString();
            labelCircle2.Text = dsKQSo[1].ToString();
            labelCircle3.Text = dsKQSo[2].ToString();
            labelCircle4.Text = dsKQSo[3].ToString();
            labelCircle5.Text = dsKQSo[4].ToString();
            labelCircle6.Text = dsKQSo[5].ToString();

        }
        private void docFileKetQua(string path)
        {

            try
            {
                StreamReader reader = new StreamReader(path);
                string text = "";
                do
                {
                    string[] chuoiGiai = new string[5];
                    text = reader.ReadLine();
                    if (text != null)
                    {
                        chuoiGiai = text.Split('#');
                        foreach (string giai in chuoiGiai)
                        {
                            string tenGiai = giai.Substring(0, giai.IndexOf('@'));
                            switch (tenGiai)
                            {
                                case "Jackpot":
                                    lbJackpot.Text = giai.Substring(giai.IndexOf('@') + 1);
                                    break;
                                case "GiaiNhat":
                                    lbGiaiNhat.Text = giai.Substring(giai.IndexOf('@') + 1);
                                    break;
                                case "GiaiNhi":
                                    lbGiaiNhi.Text = giai.Substring(giai.IndexOf('@') + 1);
                                    break;
                                case "GiaiBa":
                                    lbGiaiBa.Text = giai.Substring(giai.IndexOf('@') + 1);
                                    break;
                            }
                        }
                    }
                } while (text != null);
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void docFile()
        {
            ArrayList ds = new ArrayList();
            try
            {
                string pathThongTin =String.Format( Ticket.pathMuaVe+"ThongTinMuaVe{0}.txt",
                    Ticket.now.ToString("ddMMyyyy"));
                string kq = "";
                StreamReader reader = new StreamReader(pathThongTin);
                string text = "";
                do
                {
                    string[] dsChuoi = new string[5];

                    text = reader.ReadLine();
                    if (text != null)
                    {
                        text = text.Substring(text.IndexOf('@') + 1);
                        dsChuoi = text.Split('$');
                        foreach (string i in dsChuoi)
                        {
                            string[] dsTungVe = new string[6];
                            dsTungVe = i.Split(',');
                            foreach (string ve in dsTungVe)
                            {
                                if (ve == "")
                                    break;
                                foreach (int s in dsKQSo)
                                {
                                    string number = s.ToString();
                                    if (ve.Equals(number))
                                    {
                                        countSoTrung++;
                                        break;
                                    }
                                }

                            }
                            switch (countSoTrung)
                            {
                                case 3:
                                    countGiaiBa++;
                                    break;
                                case 4:
                                    countGiaiNhi++;
                                    break;
                                case 5:
                                    countGiaiNhat++;
                                    break;
                                case 6:
                                    countJackPot++;
                                    break;
                            }
                            countSoTrung = 0;
                            kq = String.Format("Jackpot@{0}#GiaiNhat@{1}#GiaiNhi@{2}#GiaiBa@{3}",
                                countJackPot, countGiaiNhat, countGiaiNhi, countGiaiBa);
                            File.WriteAllText(filePath, kq);

                        }
                    }
                } while (text != null);
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
