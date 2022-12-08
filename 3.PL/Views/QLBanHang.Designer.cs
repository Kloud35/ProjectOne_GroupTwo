namespace _3.PL.Views
{
    partial class QLBanHang
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
            this.btn_TaoHoaDon = new RJCodeAdvance.RJControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_HoaDonCt = new System.Windows.Forms.DataGridView();
            this.Idsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_errTck = new System.Windows.Forms.Label();
            this.lbl_errTkd = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbt_TienChuyenKhoan = new RJCodeAdvance.RJControls.RJTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbt_PTGiamGia = new RJCodeAdvance.RJControls.RJTextBox();
            this.btn_ThanhToan = new RJCodeAdvance.RJControls.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbt_TienKhachDua = new RJCodeAdvance.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbt_TienThua = new RJCodeAdvance.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbt_NgayTao = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbt_TongTien = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbt_TenNhanVien = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbt_MaHoaDon = new RJCodeAdvance.RJControls.RJTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flpn_DoChoi = new System.Windows.Forms.FlowLayoutPanel();
            this.flpn_ThucAn = new System.Windows.Forms.FlowLayoutPanel();
            this.flpn_ThuCung = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptb_Scan = new System.Windows.Forms.PictureBox();
            this.cbb_Camera = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.tbt_Barcode = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_TruSl = new System.Windows.Forms.Button();
            this.btn_CongSl = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDonCt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Scan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_TaoHoaDon.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_TaoHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TaoHoaDon.BorderRadius = 0;
            this.btn_TaoHoaDon.BorderSize = 0;
            this.btn_TaoHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_TaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(873, 213);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(132, 46);
            this.btn_TaoHoaDon.TabIndex = 22;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.TextColor = System.Drawing.Color.White;
            this.btn_TaoHoaDon.UseVisualStyleBackColor = false;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_HoaDonCt);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(17, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 284);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // dtgv_HoaDonCt
            // 
            this.dtgv_HoaDonCt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HoaDonCt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idsp,
            this.dataGridViewTextBoxColumn5,
            this.SoLuong,
            this.DonGia,
            this.TongTien});
            this.dtgv_HoaDonCt.Location = new System.Drawing.Point(12, 20);
            this.dtgv_HoaDonCt.Name = "dtgv_HoaDonCt";
            this.dtgv_HoaDonCt.RowHeadersWidth = 51;
            this.dtgv_HoaDonCt.Size = new System.Drawing.Size(781, 258);
            this.dtgv_HoaDonCt.TabIndex = 14;
            this.dtgv_HoaDonCt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HoaDonCt_CellClick);
            // 
            // Idsp
            // 
            this.Idsp.HeaderText = "Idsp";
            this.Idsp.MinimumWidth = 6;
            this.Idsp.Name = "Idsp";
            this.Idsp.Visible = false;
            this.Idsp.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
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
            // dtgv_HoaDon
            // 
            this.dtgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HoaDon.Location = new System.Drawing.Point(433, 30);
            this.dtgv_HoaDon.Name = "dtgv_HoaDon";
            this.dtgv_HoaDon.RowHeadersWidth = 51;
            this.dtgv_HoaDon.Size = new System.Drawing.Size(758, 157);
            this.dtgv_HoaDon.TabIndex = 20;
            this.dtgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HoaDon_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_errTck);
            this.groupBox2.Controls.Add(this.lbl_errTkd);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbt_TienChuyenKhoan);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbt_PTGiamGia);
            this.groupBox2.Controls.Add(this.btn_ThanhToan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbt_TienKhachDua);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbt_TienThua);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbt_NgayTao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbt_TongTien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbt_TenNhanVien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbt_MaHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(1197, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 627);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn";
            // 
            // lbl_errTck
            // 
            this.lbl_errTck.AutoSize = true;
            this.lbl_errTck.Location = new System.Drawing.Point(154, 376);
            this.lbl_errTck.Name = "lbl_errTck";
            this.lbl_errTck.Size = new System.Drawing.Size(0, 17);
            this.lbl_errTck.TabIndex = 28;
            // 
            // lbl_errTkd
            // 
            this.lbl_errTkd.AutoSize = true;
            this.lbl_errTkd.Location = new System.Drawing.Point(156, 311);
            this.lbl_errTkd.Name = "lbl_errTkd";
            this.lbl_errTkd.Size = new System.Drawing.Size(0, 17);
            this.lbl_errTkd.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tiền Chuyển Khoản";
            // 
            // tbt_TienChuyenKhoan
            // 
            this.tbt_TienChuyenKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_TienChuyenKhoan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_TienChuyenKhoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_TienChuyenKhoan.BorderRadius = 0;
            this.tbt_TienChuyenKhoan.BorderSize = 2;
            this.tbt_TienChuyenKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_TienChuyenKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_TienChuyenKhoan.Location = new System.Drawing.Point(156, 395);
            this.tbt_TienChuyenKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_TienChuyenKhoan.Multiline = false;
            this.tbt_TienChuyenKhoan.Name = "tbt_TienChuyenKhoan";
            this.tbt_TienChuyenKhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_TienChuyenKhoan.PasswordChar = false;
            this.tbt_TienChuyenKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_TienChuyenKhoan.PlaceholderText = "";
            this.tbt_TienChuyenKhoan.Size = new System.Drawing.Size(155, 35);
            this.tbt_TienChuyenKhoan.TabIndex = 25;
            this.tbt_TienChuyenKhoan.Texts = "0";
            this.tbt_TienChuyenKhoan.UnderlinedStyle = false;
            this.tbt_TienChuyenKhoan._TextChanged += new System.EventHandler(this.tbt_TienChuyenKhoan__TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Phần trăm giảm giá";
            // 
            // tbt_PTGiamGia
            // 
            this.tbt_PTGiamGia.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_PTGiamGia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_PTGiamGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_PTGiamGia.BorderRadius = 0;
            this.tbt_PTGiamGia.BorderSize = 2;
            this.tbt_PTGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_PTGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_PTGiamGia.Location = new System.Drawing.Point(156, 206);
            this.tbt_PTGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_PTGiamGia.Multiline = false;
            this.tbt_PTGiamGia.Name = "tbt_PTGiamGia";
            this.tbt_PTGiamGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_PTGiamGia.PasswordChar = false;
            this.tbt_PTGiamGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_PTGiamGia.PlaceholderText = "";
            this.tbt_PTGiamGia.Size = new System.Drawing.Size(155, 35);
            this.tbt_PTGiamGia.TabIndex = 23;
            this.tbt_PTGiamGia.Texts = "";
            this.tbt_PTGiamGia.UnderlinedStyle = false;
            this.tbt_PTGiamGia._TextChanged += new System.EventHandler(this.tbt_PTGiamGia__TextChanged);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ThanhToan.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThanhToan.BorderRadius = 0;
            this.btn_ThanhToan.BorderSize = 0;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(76, 550);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(188, 50);
            this.btn_ThanhToan.TabIndex = 22;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.TextColor = System.Drawing.Color.White;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tiền Khách Đưa";
            // 
            // tbt_TienKhachDua
            // 
            this.tbt_TienKhachDua.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_TienKhachDua.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_TienKhachDua.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_TienKhachDua.BorderRadius = 0;
            this.tbt_TienKhachDua.BorderSize = 2;
            this.tbt_TienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_TienKhachDua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_TienKhachDua.Location = new System.Drawing.Point(156, 332);
            this.tbt_TienKhachDua.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_TienKhachDua.Multiline = false;
            this.tbt_TienKhachDua.Name = "tbt_TienKhachDua";
            this.tbt_TienKhachDua.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_TienKhachDua.PasswordChar = false;
            this.tbt_TienKhachDua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_TienKhachDua.PlaceholderText = "";
            this.tbt_TienKhachDua.Size = new System.Drawing.Size(155, 35);
            this.tbt_TienKhachDua.TabIndex = 20;
            this.tbt_TienKhachDua.Texts = "";
            this.tbt_TienKhachDua.UnderlinedStyle = false;
            this.tbt_TienKhachDua._TextChanged += new System.EventHandler(this.tbt_TienKhachDua__TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tiền Thừa";
            // 
            // tbt_TienThua
            // 
            this.tbt_TienThua.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_TienThua.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_TienThua.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_TienThua.BorderRadius = 0;
            this.tbt_TienThua.BorderSize = 2;
            this.tbt_TienThua.Enabled = false;
            this.tbt_TienThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_TienThua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_TienThua.Location = new System.Drawing.Point(156, 450);
            this.tbt_TienThua.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_TienThua.Multiline = false;
            this.tbt_TienThua.Name = "tbt_TienThua";
            this.tbt_TienThua.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_TienThua.PasswordChar = false;
            this.tbt_TienThua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_TienThua.PlaceholderText = "";
            this.tbt_TienThua.Size = new System.Drawing.Size(155, 35);
            this.tbt_TienThua.TabIndex = 16;
            this.tbt_TienThua.Texts = "";
            this.tbt_TienThua.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày Tạo";
            // 
            // tbt_NgayTao
            // 
            this.tbt_NgayTao.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_NgayTao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_NgayTao.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_NgayTao.BorderRadius = 0;
            this.tbt_NgayTao.BorderSize = 2;
            this.tbt_NgayTao.Enabled = false;
            this.tbt_NgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_NgayTao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_NgayTao.Location = new System.Drawing.Point(156, 99);
            this.tbt_NgayTao.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_NgayTao.Multiline = false;
            this.tbt_NgayTao.Name = "tbt_NgayTao";
            this.tbt_NgayTao.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_NgayTao.PasswordChar = false;
            this.tbt_NgayTao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_NgayTao.PlaceholderText = "";
            this.tbt_NgayTao.Size = new System.Drawing.Size(155, 35);
            this.tbt_NgayTao.TabIndex = 14;
            this.tbt_NgayTao.Texts = "";
            this.tbt_NgayTao.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng Tiền";
            // 
            // tbt_TongTien
            // 
            this.tbt_TongTien.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_TongTien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_TongTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_TongTien.BorderRadius = 0;
            this.tbt_TongTien.BorderSize = 2;
            this.tbt_TongTien.Enabled = false;
            this.tbt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_TongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_TongTien.Location = new System.Drawing.Point(156, 271);
            this.tbt_TongTien.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_TongTien.Multiline = false;
            this.tbt_TongTien.Name = "tbt_TongTien";
            this.tbt_TongTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_TongTien.PasswordChar = false;
            this.tbt_TongTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_TongTien.PlaceholderText = "";
            this.tbt_TongTien.Size = new System.Drawing.Size(155, 35);
            this.tbt_TongTien.TabIndex = 12;
            this.tbt_TongTien.Texts = "";
            this.tbt_TongTien.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên NV";
            // 
            // tbt_TenNhanVien
            // 
            this.tbt_TenNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_TenNhanVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_TenNhanVien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_TenNhanVien.BorderRadius = 0;
            this.tbt_TenNhanVien.BorderSize = 2;
            this.tbt_TenNhanVien.Enabled = false;
            this.tbt_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_TenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_TenNhanVien.Location = new System.Drawing.Point(156, 155);
            this.tbt_TenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_TenNhanVien.Multiline = false;
            this.tbt_TenNhanVien.Name = "tbt_TenNhanVien";
            this.tbt_TenNhanVien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_TenNhanVien.PasswordChar = false;
            this.tbt_TenNhanVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_TenNhanVien.PlaceholderText = "";
            this.tbt_TenNhanVien.Size = new System.Drawing.Size(155, 35);
            this.tbt_TenNhanVien.TabIndex = 10;
            this.tbt_TenNhanVien.Texts = "";
            this.tbt_TenNhanVien.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // tbt_MaHoaDon
            // 
            this.tbt_MaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_MaHoaDon.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_MaHoaDon.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_MaHoaDon.BorderRadius = 0;
            this.tbt_MaHoaDon.BorderSize = 2;
            this.tbt_MaHoaDon.Enabled = false;
            this.tbt_MaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_MaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_MaHoaDon.Location = new System.Drawing.Point(156, 39);
            this.tbt_MaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_MaHoaDon.Multiline = false;
            this.tbt_MaHoaDon.Name = "tbt_MaHoaDon";
            this.tbt_MaHoaDon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_MaHoaDon.PasswordChar = false;
            this.tbt_MaHoaDon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_MaHoaDon.PlaceholderText = "";
            this.tbt_MaHoaDon.Size = new System.Drawing.Size(155, 35);
            this.tbt_MaHoaDon.TabIndex = 8;
            this.tbt_MaHoaDon.Texts = "";
            this.tbt_MaHoaDon.UnderlinedStyle = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.flpn_DoChoi);
            this.groupBox3.Controls.Add(this.flpn_ThucAn);
            this.groupBox3.Controls.Add(this.flpn_ThuCung);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(3, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1188, 388);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm";
            // 
            // flpn_DoChoi
            // 
            this.flpn_DoChoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpn_DoChoi.Location = new System.Drawing.Point(796, 58);
            this.flpn_DoChoi.Name = "flpn_DoChoi";
            this.flpn_DoChoi.Size = new System.Drawing.Size(339, 324);
            this.flpn_DoChoi.TabIndex = 7;
            // 
            // flpn_ThucAn
            // 
            this.flpn_ThucAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpn_ThucAn.Location = new System.Drawing.Point(408, 58);
            this.flpn_ThucAn.Name = "flpn_ThucAn";
            this.flpn_ThucAn.Size = new System.Drawing.Size(335, 324);
            this.flpn_ThucAn.TabIndex = 7;
            // 
            // flpn_ThuCung
            // 
            this.flpn_ThuCung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpn_ThuCung.Location = new System.Drawing.Point(26, 58);
            this.flpn_ThuCung.Name = "flpn_ThuCung";
            this.flpn_ThuCung.Size = new System.Drawing.Size(342, 324);
            this.flpn_ThuCung.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(941, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Đồ chơi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thức ăn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thú cưng";
            // 
            // ptb_Scan
            // 
            this.ptb_Scan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_Scan.Location = new System.Drawing.Point(64, 45);
            this.ptb_Scan.Name = "ptb_Scan";
            this.ptb_Scan.Size = new System.Drawing.Size(298, 142);
            this.ptb_Scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Scan.TabIndex = 26;
            this.ptb_Scan.TabStop = false;
            // 
            // cbb_Camera
            // 
            this.cbb_Camera.FormattingEnabled = true;
            this.cbb_Camera.Location = new System.Drawing.Point(64, 10);
            this.cbb_Camera.Name = "cbb_Camera";
            this.cbb_Camera.Size = new System.Drawing.Size(273, 28);
            this.cbb_Camera.TabIndex = 27;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Location = new System.Drawing.Point(834, 405);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 31);
            this.btn_Xoa.TabIndex = 30;
            this.btn_Xoa.Text = "X";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // tbt_Barcode
            // 
            this.tbt_Barcode.Location = new System.Drawing.Point(13, 38);
            this.tbt_Barcode.Name = "tbt_Barcode";
            this.tbt_Barcode.Size = new System.Drawing.Size(45, 27);
            this.tbt_Barcode.TabIndex = 34;
            this.tbt_Barcode.Visible = false;
            this.tbt_Barcode.TextChanged += new System.EventHandler(this.tbt_Barcode_TextChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(834, 442);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 29);
            this.btn_Clear.TabIndex = 35;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_TruSl
            // 
            this.btn_TruSl.Location = new System.Drawing.Point(834, 370);
            this.btn_TruSl.Name = "btn_TruSl";
            this.btn_TruSl.Size = new System.Drawing.Size(94, 29);
            this.btn_TruSl.TabIndex = 36;
            this.btn_TruSl.Text = "-";
            this.btn_TruSl.UseVisualStyleBackColor = true;
            this.btn_TruSl.Click += new System.EventHandler(this.btn_TruSl_Click);
            // 
            // btn_CongSl
            // 
            this.btn_CongSl.Location = new System.Drawing.Point(834, 335);
            this.btn_CongSl.Name = "btn_CongSl";
            this.btn_CongSl.Size = new System.Drawing.Size(94, 29);
            this.btn_CongSl.TabIndex = 37;
            this.btn_CongSl.Text = "+";
            this.btn_CongSl.UseVisualStyleBackColor = true;
            this.btn_CongSl.Click += new System.EventHandler(this.btn_CongSl_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(982, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nhấp đúp để chọn sản phẩm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(433, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Hóa đơn chờ";
            // 
            // QLBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_CongSl);
            this.Controls.Add(this.btn_TruSl);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.tbt_Barcode);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.cbb_Camera);
            this.Controls.Add(this.ptb_Scan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_TaoHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgv_HoaDon);
            this.Controls.Add(this.groupBox2);
            this.Name = "QLBanHang";
            this.Size = new System.Drawing.Size(1518, 893);
            this.Load += new System.EventHandler(this.QLGioHang_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.QLBanHang_ControlRemoved);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDonCt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Scan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btn_TaoHoaDon;
        private GroupBox groupBox1;
        private DataGridView dtgv_HoaDonCt;
        private DataGridView dtgv_HoaDon;
        private GroupBox groupBox2;
        private RJCodeAdvance.RJControls.RJButton btn_ThanhToan;
        private Label label5;
        private RJCodeAdvance.RJControls.RJTextBox tbt_TienKhachDua;
        private Label label7;
        private RJCodeAdvance.RJControls.RJTextBox tbt_TienThua;
        private Label label4;
        private RJCodeAdvance.RJControls.RJTextBox tbt_NgayTao;
        private Label label2;
        private RJCodeAdvance.RJControls.RJTextBox tbt_TongTien;
        private Label label1;
        private RJCodeAdvance.RJControls.RJTextBox tbt_TenNhanVien;
        private Label label3;
        private RJCodeAdvance.RJControls.RJTextBox tbt_MaHoaDon;
        private GroupBox groupBox3;
        private PictureBox ptb_Scan;
        private Label label9;
        private Label label8;
        private Label label6;
        private ComboBox cbb_Camera;
        private Label label10;
        private RJCodeAdvance.RJControls.RJTextBox tbt_PTGiamGia;
        private Button btn_Xoa;
        private TextBox tbt_Barcode;
        private Button btn_Clear;
        private Label label11;
        private RJCodeAdvance.RJControls.RJTextBox tbt_TienChuyenKhoan;
        private Button btn_TruSl;
        private Button btn_CongSl;
        private DataGridViewTextBoxColumn Idsp;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TongTien;
        private FlowLayoutPanel flpn_DoChoi;
        private FlowLayoutPanel flpn_ThucAn;
        private FlowLayoutPanel flpn_ThuCung;
        private Label lbl_errTck;
        private Label lbl_errTkd;
        private Label label12;
        private Label label13;
    }
}
