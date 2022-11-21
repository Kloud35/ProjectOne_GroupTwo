namespace _3.PL.Views
{
    partial class FrmThongTinTaiKhoan
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
            this.ptb_Avata = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.lbl_ChucVu = new System.Windows.Forms.Label();
            this.lbl_Sdt = new System.Windows.Forms.Label();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avata)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_Avata
            // 
            this.ptb_Avata.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.ptb_Avata.BorderColor = System.Drawing.Color.RoyalBlue;
            this.ptb_Avata.BorderColor2 = System.Drawing.Color.HotPink;
            this.ptb_Avata.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.ptb_Avata.BorderSize = 2;
            this.ptb_Avata.GradientAngle = 50F;
            this.ptb_Avata.Location = new System.Drawing.Point(124, 23);
            this.ptb_Avata.Name = "ptb_Avata";
            this.ptb_Avata.Size = new System.Drawing.Size(175, 175);
            this.ptb_Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Avata.TabIndex = 0;
            this.ptb_Avata.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sđt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu:";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(147, 241);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(51, 20);
            this.lbl_Ten.TabIndex = 5;
            this.lbl_Ten.Text = "Tên nv";
            // 
            // lbl_ChucVu
            // 
            this.lbl_ChucVu.AutoSize = true;
            this.lbl_ChucVu.Location = new System.Drawing.Point(147, 288);
            this.lbl_ChucVu.Name = "lbl_ChucVu";
            this.lbl_ChucVu.Size = new System.Drawing.Size(61, 20);
            this.lbl_ChucVu.TabIndex = 6;
            this.lbl_ChucVu.Text = "Chức vụ";
            // 
            // lbl_Sdt
            // 
            this.lbl_Sdt.AutoSize = true;
            this.lbl_Sdt.Location = new System.Drawing.Point(147, 343);
            this.lbl_Sdt.Name = "lbl_Sdt";
            this.lbl_Sdt.Size = new System.Drawing.Size(89, 20);
            this.lbl_Sdt.TabIndex = 7;
            this.lbl_Sdt.Text = "0123456789";
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Location = new System.Drawing.Point(147, 394);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(57, 20);
            this.lbl_MatKhau.TabIndex = 8;
            this.lbl_MatKhau.Text = "123123";
            // 
            // FrmThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 498);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_Sdt);
            this.Controls.Add(this.lbl_ChucVu);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_Avata);
            this.Name = "FrmThongTinTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmThongTinTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJCircularPictureBox ptb_Avata;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_Ten;
        private Label lbl_ChucVu;
        private Label lbl_Sdt;
        private Label lbl_MatKhau;
    }
}