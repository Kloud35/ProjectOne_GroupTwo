namespace _3.PL.Views
{
    partial class ThongKe
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
            this.pn_hoadon = new System.Windows.Forms.Panel();
            this.lb_hoadon = new System.Windows.Forms.Label();
            this.lb_tonghoadon = new System.Windows.Forms.Label();
            this.pn_doanhthu = new System.Windows.Forms.Panel();
            this.lb_tdt = new System.Windows.Forms.Label();
            this.lb_vnd = new System.Windows.Forms.Label();
            this.lb_tongdoanhthu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_day = new System.Windows.Forms.DateTimePicker();
            this.dtg_thucung = new System.Windows.Forms.DataGridView();
            this.dtg_thucan = new System.Windows.Forms.DataGridView();
            this.dtg_dochoi = new System.Windows.Forms.DataGridView();
            this.dtg_thongtin = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_daytoday = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pn_hoadon.SuspendLayout();
            this.pn_doanhthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thucung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thucan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dochoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_hoadon
            // 
            this.pn_hoadon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_hoadon.Controls.Add(this.lb_hoadon);
            this.pn_hoadon.Controls.Add(this.lb_tonghoadon);
            this.pn_hoadon.Location = new System.Drawing.Point(887, 26);
            this.pn_hoadon.Name = "pn_hoadon";
            this.pn_hoadon.Size = new System.Drawing.Size(222, 58);
            this.pn_hoadon.TabIndex = 29;
            // 
            // lb_hoadon
            // 
            this.lb_hoadon.AutoSize = true;
            this.lb_hoadon.Location = new System.Drawing.Point(32, 28);
            this.lb_hoadon.Name = "lb_hoadon";
            this.lb_hoadon.Size = new System.Drawing.Size(17, 20);
            this.lb_hoadon.TabIndex = 1;
            this.lb_hoadon.Text = "0";
            // 
            // lb_tonghoadon
            // 
            this.lb_tonghoadon.AutoSize = true;
            this.lb_tonghoadon.Location = new System.Drawing.Point(90, 0);
            this.lb_tonghoadon.Name = "lb_tonghoadon";
            this.lb_tonghoadon.Size = new System.Drawing.Size(102, 20);
            this.lb_tonghoadon.TabIndex = 0;
            this.lb_tonghoadon.Text = "Tổng hóa đơn";
            // 
            // pn_doanhthu
            // 
            this.pn_doanhthu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_doanhthu.Controls.Add(this.lb_tdt);
            this.pn_doanhthu.Controls.Add(this.lb_vnd);
            this.pn_doanhthu.Controls.Add(this.lb_tongdoanhthu);
            this.pn_doanhthu.Controls.Add(this.label2);
            this.pn_doanhthu.Location = new System.Drawing.Point(1247, 26);
            this.pn_doanhthu.Name = "pn_doanhthu";
            this.pn_doanhthu.Size = new System.Drawing.Size(234, 58);
            this.pn_doanhthu.TabIndex = 28;
            // 
            // lb_tdt
            // 
            this.lb_tdt.AutoSize = true;
            this.lb_tdt.Location = new System.Drawing.Point(39, 28);
            this.lb_tdt.Name = "lb_tdt";
            this.lb_tdt.Size = new System.Drawing.Size(17, 20);
            this.lb_tdt.TabIndex = 3;
            this.lb_tdt.Text = "0";
            // 
            // lb_vnd
            // 
            this.lb_vnd.AutoSize = true;
            this.lb_vnd.Location = new System.Drawing.Point(174, 28);
            this.lb_vnd.Name = "lb_vnd";
            this.lb_vnd.Size = new System.Drawing.Size(40, 20);
            this.lb_vnd.TabIndex = 2;
            this.lb_vnd.Text = "VND";
            // 
            // lb_tongdoanhthu
            // 
            this.lb_tongdoanhthu.AutoSize = true;
            this.lb_tongdoanhthu.Location = new System.Drawing.Point(56, 45);
            this.lb_tongdoanhthu.Name = "lb_tongdoanhthu";
            this.lb_tongdoanhthu.Size = new System.Drawing.Size(0, 20);
            this.lb_tongdoanhthu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng Doanh Thu";
            // 
            // dtp_day
            // 
            this.dtp_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_day.Location = new System.Drawing.Point(108, 50);
            this.dtp_day.Name = "dtp_day";
            this.dtp_day.Size = new System.Drawing.Size(119, 27);
            this.dtp_day.TabIndex = 24;
            this.dtp_day.ValueChanged += new System.EventHandler(this.dtp_day_ValueChanged);
            // 
            // dtg_thucung
            // 
            this.dtg_thucung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thucung.Location = new System.Drawing.Point(16, 116);
            this.dtg_thucung.Name = "dtg_thucung";
            this.dtg_thucung.RowHeadersWidth = 51;
            this.dtg_thucung.RowTemplate.Height = 29;
            this.dtg_thucung.Size = new System.Drawing.Size(474, 306);
            this.dtg_thucung.TabIndex = 19;
            // 
            // dtg_thucan
            // 
            this.dtg_thucan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thucan.Location = new System.Drawing.Point(551, 116);
            this.dtg_thucan.Name = "dtg_thucan";
            this.dtg_thucan.RowHeadersWidth = 51;
            this.dtg_thucan.RowTemplate.Height = 29;
            this.dtg_thucan.Size = new System.Drawing.Size(463, 306);
            this.dtg_thucan.TabIndex = 31;
            // 
            // dtg_dochoi
            // 
            this.dtg_dochoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dochoi.Location = new System.Drawing.Point(1047, 116);
            this.dtg_dochoi.Name = "dtg_dochoi";
            this.dtg_dochoi.RowHeadersWidth = 51;
            this.dtg_dochoi.RowTemplate.Height = 29;
            this.dtg_dochoi.Size = new System.Drawing.Size(448, 306);
            this.dtg_dochoi.TabIndex = 32;
            // 
            // dtg_thongtin
            // 
            this.dtg_thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thongtin.Location = new System.Drawing.Point(6, 111);
            this.dtg_thongtin.Name = "dtg_thongtin";
            this.dtg_thongtin.RowHeadersWidth = 51;
            this.dtg_thongtin.RowTemplate.Height = 29;
            this.dtg_thongtin.Size = new System.Drawing.Size(1501, 242);
            this.dtg_thongtin.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pn_doanhthu);
            this.groupBox1.Controls.Add(this.pn_hoadon);
            this.groupBox1.Controls.Add(this.dtp_daytoday);
            this.groupBox1.Controls.Add(this.dtg_thongtin);
            this.groupBox1.Controls.Add(this.dtp_day);
            this.groupBox1.Location = new System.Drawing.Point(3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1513, 359);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Từ :";
            // 
            // dtp_daytoday
            // 
            this.dtp_daytoday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_daytoday.Location = new System.Drawing.Point(292, 50);
            this.dtp_daytoday.Name = "dtp_daytoday";
            this.dtp_daytoday.Size = new System.Drawing.Size(119, 27);
            this.dtp_daytoday.TabIndex = 34;
            this.dtp_daytoday.ValueChanged += new System.EventHandler(this.dtp_daytoday_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_thucung);
            this.groupBox2.Controls.Add(this.dtg_thucan);
            this.groupBox2.Controls.Add(this.dtg_dochoi);
            this.groupBox2.Location = new System.Drawing.Point(0, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1513, 434);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng sản phẩm đã bán";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(1519, 875);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.pn_hoadon.ResumeLayout(false);
            this.pn_hoadon.PerformLayout();
            this.pn_doanhthu.ResumeLayout(false);
            this.pn_doanhthu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thucung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thucan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dochoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pn_hoadon;
        private Label lb_hoadon;
        private Label lb_tonghoadon;
        private Panel pn_doanhthu;
        private Label lb_tdt;
        private Label lb_vnd;
        private Label lb_tongdoanhthu;
        private Label label2;
        private DateTimePicker dtp_day;
        private DataGridView dtg_thucung;
        private DataGridView dtg_thucan;
        private DataGridView dtg_dochoi;
        private DataGridView dtg_thongtin;
        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private DateTimePicker dtp_daytoday;
        private GroupBox groupBox2;
    }
}
