namespace Vietlott
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.btnLuatChoi = new ClassLibrary1.ButtonEllipse();
            this.btnChoi = new ClassLibrary1.ButtonEllipse();
            this.btKetQua = new ClassLibrary1.ButtonEllipse();
            this.SuspendLayout();
            // 
            // btnLuatChoi
            // 
            this.btnLuatChoi.BackColor = System.Drawing.Color.DarkRed;
            this.btnLuatChoi.FlatAppearance.BorderSize = 0;
            this.btnLuatChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuatChoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnLuatChoi.ForeColor = System.Drawing.Color.White;
            this.btnLuatChoi.Location = new System.Drawing.Point(58, 397);
            this.btnLuatChoi.Name = "btnLuatChoi";
            this.btnLuatChoi.Size = new System.Drawing.Size(165, 54);
            this.btnLuatChoi.TabIndex = 0;
            this.btnLuatChoi.Text = "Luật chơi";
            this.btnLuatChoi.UseVisualStyleBackColor = false;
            this.btnLuatChoi.Click += new System.EventHandler(this.btnLuatChoi_Click);
            // 
            // btnChoi
            // 
            this.btnChoi.BackColor = System.Drawing.Color.DarkViolet;
            this.btnChoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChoi.FlatAppearance.BorderSize = 0;
            this.btnChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnChoi.ForeColor = System.Drawing.Color.White;
            this.btnChoi.Location = new System.Drawing.Point(243, 397);
            this.btnChoi.Name = "btnChoi";
            this.btnChoi.Size = new System.Drawing.Size(165, 54);
            this.btnChoi.TabIndex = 0;
            this.btnChoi.Text = "Chơi ngay";
            this.btnChoi.UseVisualStyleBackColor = false;
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);
            // 
            // btKetQua
            // 
            this.btKetQua.BackColor = System.Drawing.Color.Chocolate;
            this.btKetQua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btKetQua.FlatAppearance.BorderSize = 0;
            this.btKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKetQua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btKetQua.ForeColor = System.Drawing.Color.White;
            this.btKetQua.Location = new System.Drawing.Point(143, 467);
            this.btKetQua.Name = "btKetQua";
            this.btKetQua.Size = new System.Drawing.Size(165, 54);
            this.btKetQua.TabIndex = 1;
            this.btKetQua.Text = "Kết quả";
            this.btKetQua.UseVisualStyleBackColor = false;
            this.btKetQua.Click += new System.EventHandler(this.btKetQua_Click);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vietlott.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(909, 598);
            this.Controls.Add(this.btKetQua);
            this.Controls.Add(this.btnChoi);
            this.Controls.Add(this.btnLuatChoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIETLOTT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrangChu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTrangChu_FormClosed);
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.ButtonEllipse btnLuatChoi;
        private ClassLibrary1.ButtonEllipse btnChoi;
        private ClassLibrary1.ButtonEllipse btKetQua;
    }
}

