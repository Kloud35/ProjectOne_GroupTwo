using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Properties;
using System.Data;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace _3.PL.Views
{
    public partial class QLNhanVien : UserControl
    {
        INhanVienServices _iNhanVienServices;
        IChucVuServices _iChucVuServices;
        ICuaHangServices _iCuaHangServices;
        Guid currentId;
        string imgLocation;
        public QLNhanVien()
        {
            InitializeComponent();
            _iNhanVienServices = new NhanVienServices();
            _iChucVuServices = new ChucVuServices();
            _iCuaHangServices = new CuaHangServices();

        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadToCombobox();
        }

        private void LoadData()
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 15;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Họ và tên";
            dtgv_Show.Columns[4].Name = "Ngày sinh";
            dtgv_Show.Columns[5].Name = "Giới tính";
            dtgv_Show.Columns[6].Name = "Sđt";
            dtgv_Show.Columns[7].Name = "Email";
            dtgv_Show.Columns[8].Name = "Mật khẩu";
            dtgv_Show.Columns[9].Name = "Chức vụ";
            dtgv_Show.Columns[10].Name = "Cửa hàng";
            dtgv_Show.Columns[11].Name = "Địa chỉ";
            dtgv_Show.Columns[12].Name = "Thành phố";
            dtgv_Show.Columns[13].Name = "Quốc gia";
            dtgv_Show.Columns[14].Name = "Trạng thái";
            var list = _iNhanVienServices.GetAll();
            if (tbt_Search.Texts != "")
            {
                list = _iNhanVienServices.GetAll().Where(x => x.Ten.ToLower().Contains(tbt_Search.Texts.ToLower())).ToList();
            }
            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.Ma, item.HoVaTen, item.NgaySinh, item.GioiTinh, item.Sdt, item.Email, item.MatKhau, item.ChucVu, item.CuaHang, item.DiaChi, item.ThanhPho, item.QuocGia, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void LoadToCombobox()
        {
            foreach (var item in _iChucVuServices.GetAll())
            {
                cbb_ChucVu.Items.Add(item.Ten);
            }
            foreach (var item in _iCuaHangServices.GetAll())
            {
                cbb_CuaHang.Items.Add(item.Ten);
            }
        }
        
        public void SendMail(string sendTo, string body)
        {
            try
            {
                string mail = "khanhnnph28375@fpt.edu.vn";
                SmtpClient client = new SmtpClient();
                //setup SMTP Host Here
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(mail,"Kh@nhlazy2033");
                //converte string to MailAdress

                MailAddress to = new MailAddress(sendTo);
                MailAddress from = new MailAddress(mail);
                MailMessage msg = new MailMessage();
                //set up message settings

                msg.Subject = "GỬI MẬT KHẨU CHO NHÂN VIÊN MỚI";
                msg.SubjectEncoding = Encoding.UTF8;
                msg.Body = body;
                msg.BodyEncoding = Encoding.UTF8;
                msg.From = from;
                msg.To.Add(to);
                // Enviar E-mail
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(msg);
                MessageBox.Show("Đã gửi tài khoản mật khẩu đến email nhân viên");
            }
            catch (Exception error)
            {
                MessageBox.Show("Unexpected Error: " + error);
            }
        }
        
        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var x = new NhanVienView()
            {
                Id = Guid.NewGuid(),
                Ma = tbt_Ma.Texts,
                Ho = tbt_Ho.Texts,
                TenDem = tbt_TenDem.Texts,
                Ten = tbt_Ten.Texts,
                NgaySinh = dtp_NgaySinh.Value,
                GioiTinh = rbn_GtNam.Checked ? "Nam" : "Nữ",
                Sdt = tbt_Sdt.Texts,
                Email = tbt_Email.Texts,
                DiaChi = tbt_DiaChi.Texts,
                ThanhPho = tbt_ThanhPho.Texts,
                QuocGia = tbt_QuocGia.Texts,
                MatKhau = tbt_MatKhau.Texts,
                TrangThai = cbb_TrangThai.SelectedIndex,
                IdCh = _iCuaHangServices.GetAll().FirstOrDefault(x => x.Ten.Equals(cbb_CuaHang.Texts)).Id,
                IdCv = _iChucVuServices.GetAll().FirstOrDefault(x => x.Ten.Equals(cbb_ChucVu.Texts)).Id,
                Image = imgLocation,
            };
            if (_iNhanVienServices.Add(x))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
                SendMail(tbt_Email.Texts, $"Tài khoản của nhân viên:\n SĐT: {x.Sdt} \n Mật khẩu : {x.MatKhau}");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var x = _iNhanVienServices.GetAll().FirstOrDefault(x => x.Id == currentId);
                x.Ma = tbt_Ma.Texts;
                x.Ho = tbt_Ho.Texts;
                x.TenDem = tbt_TenDem.Texts;
                x.Ten = tbt_Ten.Texts;
                x.NgaySinh = dtp_NgaySinh.Value;
                x.GioiTinh = rbn_GtNam.Checked ? "Nam" : "Nữ";
                x.Sdt = tbt_Sdt.Texts;
                x.Email = tbt_Email.Texts;
                x.DiaChi = tbt_DiaChi.Texts;
                x.ThanhPho = tbt_ThanhPho.Texts;
                x.QuocGia = tbt_QuocGia.Texts;
                x.MatKhau = tbt_MatKhau.Texts;
                x.TrangThai = cbb_TrangThai.SelectedIndex;
                x.IdCh = _iCuaHangServices.GetAll().FirstOrDefault(x => x.Ten.Equals(cbb_CuaHang.Texts)).Id;
                x.IdCv = _iChucVuServices.GetAll().FirstOrDefault(x => x.Ten.Equals(cbb_ChucVu.Texts)).Id;
                x.Image = imgLocation;
                if (_iNhanVienServices.Update(x))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var x = _iNhanVienServices.GetAll().FirstOrDefault(x => x.Id == currentId);
                if (_iNhanVienServices.Delete(x))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
        private void Clear()
        {
            tbt_DiaChi.Texts = "";
            tbt_Email.Texts = "";
            tbt_Ho.Texts = "";
            tbt_Ma.Texts = "";
            tbt_MatKhau.Texts = "";
            tbt_QuocGia.Texts = "";
            tbt_Sdt.Texts = "";
            tbt_Search.Texts = "";
            tbt_Ten.Texts = "";
            tbt_TenDem.Texts = "";
            tbt_ThanhPho.Texts = "";
            dtp_NgaySinh.Value = DateTime.Now;
            cbb_ChucVu.Texts = "";
            cbb_CuaHang.Texts = "";
            rbn_GtNam.Checked = false;
            rbn_GtNu.Checked = false;
            cbb_TrangThai.Texts = "";
            ptb_Image.Image = Resources.illustration_profile_icon_avatar_inhabitant_male_illustration_profile_icon_avata_237916010;
        }
        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Show.CurrentCell != null && dtgv_Show.CurrentCell.Value != null)
            {
                currentId = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
                var x = _iNhanVienServices.GetAll().FirstOrDefault(x => x.Id == currentId);
                tbt_Ma.Texts = x.Ma;
                tbt_Ho.Texts = x.Ho;
                tbt_TenDem.Texts = x.TenDem;
                tbt_Ten.Texts = x.Ten;
                dtp_NgaySinh.Value = x.NgaySinh;
                if (x.GioiTinh == "Nam")
                {
                    rbn_GtNam.Checked = true;
                }
                else
                {
                    rbn_GtNu.Checked = true;
                }
                tbt_Sdt.Texts = x.Sdt;
                tbt_Email.Texts = x.Email;
                tbt_DiaChi.Texts = x.DiaChi;
                tbt_ThanhPho.Texts = x.ThanhPho;
                tbt_QuocGia.Texts = x.QuocGia;
                tbt_MatKhau.Texts = x.MatKhau;
                if (x.TrangThai == 0)
                {
                    cbb_TrangThai.SelectedIndex = 0;
                }
                else
                {
                    cbb_TrangThai.SelectedIndex = 1;
                }
                cbb_ChucVu.Texts = x.ChucVu;
                cbb_CuaHang.Texts = x.CuaHang;
                ptb_Image.Image = Image.FromFile(x.Image);
                imgLocation = x.Image;
            }
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ptb_Image.Image = Image.FromFile(fileDialog.FileName);
                imgLocation = fileDialog.FileName;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
