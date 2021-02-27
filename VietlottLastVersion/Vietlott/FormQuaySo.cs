using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace Vietlott
{
    public partial class FormQuaySo : Form
    {
        Random rand = new Random();
        Label[] label = new Label[6];
        Label lbNgayThang = new Label();
        List<int> randomList = new List<int>();
        ArrayList dsKQ = new ArrayList(6);

        public Label LabelNgayThang
        {
            get { return lbNgayThang; }
        }

        public FormQuaySo()
        {
            InitializeComponent();
        }

        private void FormQuaySo_Load(object sender, EventArgs e)
        {
            lbNgayThang.Name = "lbNgayThang";
            lbNgayThang.ForeColor = Color.Black;
            lbNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            lbNgayThang.Location = new System.Drawing.Point(100, 100);
            lbNgayThang.Size = new System.Drawing.Size(618, 50);
            lbNgayThang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbNgayThang.Text = String.Format("Kết quả quay thưởng Mega 6/45 ngày {0}",
                    Ticket.now.ToString("dd/MM"));
            this.Controls.Add(lbNgayThang);
            btnKetQua.Visible = false;
            quaySo();

        }

        private void quaySo()
        {
            int i = 0;
            int a = rand.Next(1, 46);
            Thread thread = new Thread(t =>
            {
                while (i < label.Length)
                {

                    if (!randomList.Contains(a))
                    {
                        label[i] = new LabelCircle();
                        label[i].Location = new Point(i * 80, 43);
                        panel1.Invoke(new MethodInvoker(delegate ()
                        {
                            panel1.Controls.Add(label[i]);
                            randomList.Add(a);
                            label[i].Text = a.ToString();
                            int so = int.Parse(label[i].Text);
                            FormKetQua.dsKQSo.Add(a);
                            i++;
                            if (i == label.Length)
                                btnKetQua.Visible = true;
                        }));

                    }
                    else
                        a = rand.Next(1, 46);
                    Thread.Sleep(900);

                }
            });
            thread.Start();



        }


        private void btnKetQua_Click(object sender, EventArgs e)
        {
            FormKetQua formKQ = new FormKetQua();
            this.Hide();
            formKQ.ShowDialog();
        }

    }
}
