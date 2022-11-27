namespace _3.PL.Views
{
    partial class FrmLogin
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
            this.tbt_Sdt = new RJCodeAdvance.RJControls.RJTextBox();
            this.tbt_MatKhau = new RJCodeAdvance.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Login = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_QuenMk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbt_Sdt
            // 
            this.tbt_Sdt.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_Sdt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_Sdt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_Sdt.BorderRadius = 0;
            this.tbt_Sdt.BorderSize = 2;
            this.tbt_Sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Sdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_Sdt.Location = new System.Drawing.Point(61, 218);
            this.tbt_Sdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_Sdt.Multiline = false;
            this.tbt_Sdt.Name = "tbt_Sdt";
            this.tbt_Sdt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_Sdt.PasswordChar = false;
            this.tbt_Sdt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_Sdt.PlaceholderText = "";
            this.tbt_Sdt.Size = new System.Drawing.Size(312, 35);
            this.tbt_Sdt.TabIndex = 0;
            this.tbt_Sdt.Texts = "";
            this.tbt_Sdt.UnderlinedStyle = false;
            // 
            // tbt_MatKhau
            // 
            this.tbt_MatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_MatKhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_MatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_MatKhau.BorderRadius = 0;
            this.tbt_MatKhau.BorderSize = 2;
            this.tbt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_MatKhau.Location = new System.Drawing.Point(61, 283);
            this.tbt_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_MatKhau.Multiline = false;
            this.tbt_MatKhau.Name = "tbt_MatKhau";
            this.tbt_MatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_MatKhau.PasswordChar = true;
            this.tbt_MatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_MatKhau.PlaceholderText = "";
            this.tbt_MatKhau.Size = new System.Drawing.Size(312, 35);
            this.tbt_MatKhau.TabIndex = 1;
            this.tbt_MatKhau.Texts = "";
            this.tbt_MatKhau.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3.PL.Properties.Resources.FPT_Polytechnic;
            this.pictureBox1.Location = new System.Drawing.Point(77, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Login.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Login.BorderRadius = 0;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(111, 392);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(188, 50);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.TextColor = System.Drawing.Color.White;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // lbl_QuenMk
            // 
            this.lbl_QuenMk.AutoSize = true;
            this.lbl_QuenMk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_QuenMk.Location = new System.Drawing.Point(253, 327);
            this.lbl_QuenMk.Name = "lbl_QuenMk";
            this.lbl_QuenMk.Size = new System.Drawing.Size(118, 20);
            this.lbl_QuenMk.TabIndex = 8;
            this.lbl_QuenMk.Text = "Quên mật khẩu ?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quản lý cửa hàng thú cưng";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 537);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_QuenMk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbt_MatKhau);
            this.Controls.Add(this.tbt_Sdt);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox tbt_Sdt;
        private RJCodeAdvance.RJControls.RJTextBox tbt_MatKhau;
        private PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJButton btn_Login;
        private Label label1;
        private Label label2;
        private Label lbl_QuenMk;
        private Label label5;
    }
}