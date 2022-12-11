namespace _3.PL.Views
{
    partial class QLHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_HoaDonCt = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_In = new RJCodeAdvance.RJControls.RJButton();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDonCt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_Time);
            this.groupBox1.Controls.Add(this.dtgv_HoaDon);
            this.groupBox1.Location = new System.Drawing.Point(6, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // dtgv_HoaDon
            // 
            this.dtgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HoaDon.Location = new System.Drawing.Point(37, 75);
            this.dtgv_HoaDon.Name = "dtgv_HoaDon";
            this.dtgv_HoaDon.RowHeadersWidth = 51;
            this.dtgv_HoaDon.RowTemplate.Height = 29;
            this.dtgv_HoaDon.Size = new System.Drawing.Size(1145, 227);
            this.dtgv_HoaDon.TabIndex = 0;
            this.dtgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HoaDon_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_HoaDonCt);
            this.groupBox2.Location = new System.Drawing.Point(6, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1221, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dtgv_HoaDonCt
            // 
            this.dtgv_HoaDonCt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HoaDonCt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.SoLuong,
            this.DonGia,
            this.TongTien});
            this.dtgv_HoaDonCt.Location = new System.Drawing.Point(37, 69);
            this.dtgv_HoaDonCt.Name = "dtgv_HoaDonCt";
            this.dtgv_HoaDonCt.RowHeadersWidth = 51;
            this.dtgv_HoaDonCt.RowTemplate.Height = 29;
            this.dtgv_HoaDonCt.Size = new System.Drawing.Size(1145, 188);
            this.dtgv_HoaDonCt.TabIndex = 0;
            this.dtgv_HoaDonCt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HoaDonCt_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_In.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_In.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_In.BorderRadius = 0;
            this.btn_In.BorderSize = 0;
            this.btn_In.FlatAppearance.BorderSize = 0;
            this.btn_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_In.ForeColor = System.Drawing.Color.White;
            this.btn_In.Location = new System.Drawing.Point(1014, 12);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(188, 50);
            this.btn_In.TabIndex = 2;
            this.btn_In.Text = "Xuất hóa đơn";
            this.btn_In.TextColor = System.Drawing.Color.White;
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // dtp_Time
            // 
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Time.Location = new System.Drawing.Point(37, 42);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(166, 27);
            this.dtp_Time.TabIndex = 1;
            this.dtp_Time.ValueChanged += new System.EventHandler(this.dtp_Time_ValueChanged);
            // 
            // QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Size = new System.Drawing.Size(1227, 727);
            this.Load += new System.EventHandler(this.QLHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDonCt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtgv_HoaDon;
        private GroupBox groupBox2;
        private DataGridView dtgv_HoaDonCt;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TongTien;
        private RJCodeAdvance.RJControls.RJButton btn_In;
        private DateTimePicker dtp_Time;
    }
}
