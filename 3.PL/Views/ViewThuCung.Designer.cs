namespace _3.PL.Views
{
    partial class ViewThuCung
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
            this.tsmi_ThuCung = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_GiongLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_MauSac = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Desktop = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ThuCung,
            this.tsmi_GiongLoai,
            this.tsmi_MauSac});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_ThuCung
            // 
            this.tsmi_ThuCung.Name = "tsmi_ThuCung";
            this.tsmi_ThuCung.Size = new System.Drawing.Size(84, 24);
            this.tsmi_ThuCung.Text = "Thú cưng";
            this.tsmi_ThuCung.Click += new System.EventHandler(this.tsmi_ThuCung_Click);
            // 
            // tsmi_GiongLoai
            // 
            this.tsmi_GiongLoai.Name = "tsmi_GiongLoai";
            this.tsmi_GiongLoai.Size = new System.Drawing.Size(92, 24);
            this.tsmi_GiongLoai.Text = "Giống loài";
            this.tsmi_GiongLoai.Click += new System.EventHandler(this.tsmi_GiongLoai_Click);
            // 
            // tsmi_MauSac
            // 
            this.tsmi_MauSac.Name = "tsmi_MauSac";
            this.tsmi_MauSac.Size = new System.Drawing.Size(77, 24);
            this.tsmi_MauSac.Text = "Màu sắc";
            this.tsmi_MauSac.Click += new System.EventHandler(this.tsmi_MauSac_Click);
            // 
            // pn_Desktop
            // 
            this.pn_Desktop.Location = new System.Drawing.Point(0, 31);
            this.pn_Desktop.Name = "pn_Desktop";
            this.pn_Desktop.Size = new System.Drawing.Size(1227, 696);
            this.pn_Desktop.TabIndex = 2;
            // 
            // ViewThuCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_Desktop);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewThuCung";
            this.Size = new System.Drawing.Size(1227, 727);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmi_ThuCung;
        private Panel pn_Desktop;
        private ToolStripMenuItem tsmi_GiongLoai;
        private ToolStripMenuItem tsmi_MauSac;
    }
}
