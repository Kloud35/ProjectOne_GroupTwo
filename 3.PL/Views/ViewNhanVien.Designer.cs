namespace _3.PL.Views
{
    partial class ViewNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ChuVu = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Desktop = new System.Windows.Forms.Panel();
            this.tsmi_CuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_NhanVien,
            this.tsmi_ChuVu,
            this.tsmi_CuaHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_NhanVien
            // 
            this.tsmi_NhanVien.Name = "tsmi_NhanVien";
            this.tsmi_NhanVien.Size = new System.Drawing.Size(89, 24);
            this.tsmi_NhanVien.Text = "Nhân viên";
            this.tsmi_NhanVien.Click += new System.EventHandler(this.tsmi_NhanVien_Click);
            // 
            // tsmi_ChuVu
            // 
            this.tsmi_ChuVu.Name = "tsmi_ChuVu";
            this.tsmi_ChuVu.Size = new System.Drawing.Size(75, 24);
            this.tsmi_ChuVu.Text = "Chức vụ";
            this.tsmi_ChuVu.Click += new System.EventHandler(this.tsmi_ChuVu_Click);
            // 
            // pn_Desktop
            // 
            this.pn_Desktop.Location = new System.Drawing.Point(0, 31);
            this.pn_Desktop.Name = "pn_Desktop";
            this.pn_Desktop.Size = new System.Drawing.Size(1227, 696);
            this.pn_Desktop.TabIndex = 1;
            // 
            // tsmi_CuaHang
            // 
            this.tsmi_CuaHang.Name = "tsmi_CuaHang";
            this.tsmi_CuaHang.Size = new System.Drawing.Size(86, 24);
            this.tsmi_CuaHang.Text = "Cửa hàng";
            this.tsmi_CuaHang.Click += new System.EventHandler(this.tsmi_CuaHang_Click);
            // 
            // ViewNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_Desktop);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewNhanVien";
            this.Size = new System.Drawing.Size(1227, 727);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmi_NhanVien;
        private ToolStripMenuItem tsmi_ChuVu;
        private Panel pn_Desktop;
        private ToolStripMenuItem tsmi_CuaHang;
    }
}
