namespace Vietlott
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.btnBack = new ClassLibrary1.ButtonEllipse();
            this.btLogin = new ClassLibrary1.ButtonEllipse();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Crimson;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("VNI-Hobo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(30, 315);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 95);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Trôû veà";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btLogin_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btLogin_MouseLeave);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Crimson;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.Font = new System.Drawing.Font("VNI-Hobo", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(261, 315);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(201, 95);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Ñaêng nhaäp";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            this.btLogin.MouseEnter += new System.EventHandler(this.btLogin_MouseEnter);
            this.btLogin.MouseLeave += new System.EventHandler(this.btLogin_MouseLeave);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.ForeColor = System.Drawing.Color.Gray;
            this.tbPhone.Location = new System.Drawing.Point(42, 229);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(428, 31);
            this.tbPhone.TabIndex = 1;
            this.tbPhone.Text = "Nhập số điện thoại của bạn...";
            this.tbPhone.Click += new System.EventHandler(this.tbName_Click);
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("VNI-Hobo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soá ñieän thoaïi:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Gray;
            this.tbName.Location = new System.Drawing.Point(42, 144);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(428, 31);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Nhập họ tên của bạn...";
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("VNI-Hobo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hoï teân:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("VNI-Hobo", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 81);
            this.label1.TabIndex = 9;
            this.label1.Text = "ÑAÊNG NHAÄP NGAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(29, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 439);
            this.panel1.TabIndex = 0;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 492);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN FORM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ClassLibrary1.ButtonEllipse btLogin;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private ClassLibrary1.ButtonEllipse btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}