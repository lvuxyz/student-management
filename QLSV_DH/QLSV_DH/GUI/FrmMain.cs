//using DevExpress.Data.Filtering;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_DH
{
    public delegate void SendMessage(String value, String quyen);
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
        }
        static String quyenhan = "";
        static String username = "";
        private void SetValue(String value, String quyen) //truyền giá trị nhận từ form frmlogin
        {
            this.lblTrangThaiDN.Text = "Xin chào : " + value;
            this.trangthaidn = true;
            quyenhan = quyen;
            username = value;
            LoadLai(value, quyen);
        }

        //private Button currentButton;

        private Guna2Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        public Boolean trangthaidn = false;
        public String tendn;


        public void EnableMenuAdmin()
        {
            btnHoSoSinhVien.Enabled = true;
            btnHoSoTamTru.Enabled = true;
            btnDiemRenLuyen.Enabled = true;
            btnDiaDanh.Enabled = true;
            btnDanhSachLop.Enabled = true;
            btnDanhSachKhoa.Enabled = true;
            btnThongKe.Enabled = true;
            btnQLMonHoc.Enabled = true;
            btnQLTaiKhoan.Enabled = true;
            btnQLGiangVien.Enabled = true;
            btnQLDiem.Enabled = true;
            btnTBTL.Enabled = true;
            btnNhapDiem.Enabled = true;
            btnXetHocBong.Enabled = true;
            btn_DiemDanh.Enabled = true;
            btn_Notication.Enabled = true;


            btnHoSoSinhVien.Visible = true;
            btnHoSoTamTru.Visible = true;
            btnDiemRenLuyen.Visible = true;
            btnDiaDanh.Visible = true;
            btnDanhSachLop.Visible = true;
            btnDanhSachKhoa.Visible = true;
            btnThongKe.Visible = true;
            btnQLMonHoc.Visible = true;
            btnQLTaiKhoan.Visible = true;
            btnQLGiangVien.Visible = true;
            btnQLDiem.Visible = true;
            btnTBTL.Visible = true;
            btnNhapDiem.Visible = true;
            btnXetHocBong.Visible = true;
            btn_DiemDanh.Visible = true;
            btn_Notication.Visible = true;
        }

        public void DisableMenuAdmin()
        {
            btnHoSoSinhVien.Enabled = false;
            btnHoSoTamTru.Enabled = false;
            btnDiemRenLuyen.Enabled = false;
            btnDiaDanh.Enabled = false;
            btnDanhSachLop.Enabled = false;
            btnDanhSachKhoa.Enabled = false;
            btnThongKe.Enabled = false;
            btnQLMonHoc.Enabled = false;
            btnQLTaiKhoan.Enabled = false;
            btnQLGiangVien.Enabled = false;
            btnQLDiem.Enabled = false;
            btnTBTL.Enabled = false;
            btnXetHocBong.Enabled = false;
            btn_DiemDanh.Enabled = false;

            btnHoSoSinhVien.Visible = false;
            btnHoSoTamTru.Visible = false;
            btnDiemRenLuyen.Visible = false;
            btnDiaDanh.Visible = false;
            btnDanhSachLop.Visible = false;
            btnDanhSachKhoa.Visible = false;
            btnThongKe.Visible = false;
            btnQLMonHoc.Visible = false;
            btnQLTaiKhoan.Visible = false;
            btnQLGiangVien.Visible = false;
            btnQLDiem.Visible = false;
            btnTBTL.Visible = false;
            btnXetHocBong.Visible = false;
            btn_DiemDanh.Visible = false;
            btn_Notication.Visible = false;
        }
        public void EnableMenuSV()
        {
            btnHoSoSinhVien.Enabled = true;
            btnHoSoTamTru.Enabled = true;
            btnDiemRenLuyen.Enabled = true;
            btnNhapDiem.Enabled = false;
            btnQLMonHoc.Enabled = false;
            btnQLDiem.Enabled = true;
            btnNhapDiem.Enabled = false;

            btnHoSoSinhVien.Visible = true;
            btnHoSoTamTru.Visible = true;
            btnDiemRenLuyen.Visible = true;
            btnNhapDiem.Visible = false;
            btnQLMonHoc.Visible = false;
            btnQLDiem.Visible = true;

            btnNhapDiem.Visible = false;
        }
        public void EnableMenuGV()
        {
            btnDiemRenLuyen.Enabled = true;
            btnNhapDiem.Enabled = true;
            btnXemDiem.Enabled = true;
            btnQLGiangVien.Enabled = true;
            btn_DiemDanh.Enabled = true;
            btnQLGiangVien.Text = "GIẢNG VIÊN";


            btnDiemRenLuyen.Visible = true;
            btnNhapDiem.Visible = true;
            btnXemDiem.Visible = true;
            btnQLGiangVien.Visible = true;
            btn_DiemDanh.Visible = true;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Guna2Button)btnSender)
                {
                    DisnableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Guna2Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.FillColor = Color.Tomato;
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisnableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn is Guna.UI2.WinForms.Guna2Button gunaButton)
                {
                    gunaButton.BackColor = Color.Black;
                    gunaButton.ForeColor = Color.Gainsboro;
                    gunaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    gunaButton.FillColor = Color.Black; // Add this line to set the FillColor to black
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void OpenChildFormLogin(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            this.panelDesktopPane.Dock = DockStyle.Fill;
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void Reset()
        {
            DisnableButton();
            lblTitle.Text = "HOME";

            currentButton = null;
            btnCloseChildForm.Visible = false;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (trangthaidn == false)
            {
                lblTrangThaiDN.Text = "Bạn Chưa Đăng Nhập";
                DisableMenuAdmin();
            }
            else
            {
                btnDangNhap.Enabled = false;
                lblTrangThaiDN.Text = "Xin chào : " + tendn;
                thoatLogin.Text = "Thoát";
                EnableMenuAdmin();
            }
        }

        private async Task RunTextAnimation(Guna2HtmlLabel label)
        {
            int startX = label.Right; 
            int endX = -label.Width;  

            while (label.Left > endX)
            {
                label.Left -= 1; // Điều chỉnh vận tốc chạy chữ 

                await Task.Delay(100);
            }

            label.Left = startX; 
        }
        private async void StartTextAnimation()
        {
            await RunTextAnimation(lb_ThongBao); // Thay gunaLabel1 bằng tên GunaLabel của bạn
        }
        public int LoadSoBuoiNghi(string Msv)
        {
            int soBuoiNghi = 0;
            string connectionString = ConnectionString.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM DiemDanh WHERE MSV = @Msv AND Status = '0'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Msv", Msv);

                    // Thực hiện truy vấn và lấy kết quả đếm
                    soBuoiNghi = (int)command.ExecuteScalar();
                }
            }

            return soBuoiNghi;
        }

        int sttTb = 0;
        public void LoadLai(String tendnhap, String quyen)
        {
            if (trangthaidn == false)
            {
                lblTrangThaiDN.Text = "Bạn Chưa Đăng Nhập";
                DisableMenuAdmin();
            }
            else
            {
                lblTrangThaiDN.Text = "Xin chào : " + tendnhap + "(" + quyen + ")";
                lblTitle.Text = "HOME";
                thoatLogin.Text = "Thoát";
                if (quyen == "Quản Lý")
                {
                    EnableMenuAdmin();
                    btnDangNhap.Text = "MỞ LỚP HỌC";
                    btnQLDiem.Text = " QUẢN LÝ ĐIỂM";
                    btnQLGiangVien.Text = "  QL GIẢNG VIÊN";
                    linkdoimatkhau.Visible = true;
                    panel4.Visible = true;
                    tbSinhVien(quyen);
                   // StartTextAnimation();
                }
                else if (quyen == "Sinh Viên")
                {
                    int buoiNghi = LoadSoBuoiNghi(username);
                    if (buoiNghi == 1 || buoiNghi == 2)
                    {
                        Message ms = new Message(sttTb++, "Hệ Thống", "Bạn đã nghỉ " + buoiNghi + " Buổi Cần lưu ý để tránh không đủ điều kiện thi.", sobuoi: buoiNghi);
                        ms.Show();
                    }
                    else if (buoiNghi == 3)
                    {
                        Message ms = new Message(sttTb++, "Hệ Thống", "Bạn đã nghỉ " + buoiNghi + " Buổi \n\r Bạn đã bị Cấm thi do nghỉ quá số buổi cho phép.", sobuoi: buoiNghi);
                        ms.Show();
                    }
                    Thread.Sleep(500);
                    tbSinhVien(quyen);
                    EnableMenuSV();
                    btnDangNhap.Text = "ĐĂNG KÝ HỌC";
                    btnQLDiem.Text = "  ĐIỂM MÔN HỌC";
                    linkdoimatkhau.Visible = true;
                    panel4.Visible = true;
                }
                else if (quyen == "Giảng Viên")
                {
                    tbSinhVien(quyen);
                    btnDangNhap.Text = "";
                    EnableMenuGV();
                    btnQLDiem.Text = "QL ĐIỂM";
                    linkdoimatkhau.Visible = true;
                    panel4.Visible = true;
                    btnDangNhap.Text = "ĐIỂM SV";
                }
                getAllTB();
            }
        }

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;


        void tbSinhVien(string doiTuong)
        {
            string noiDung = "";
            sqlConnection = new SqlConnection(ConnectionString.connectionString);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            try
            {
                sqlConnection.Open();
                DateTime currentDate = DateTime.Now;
                sqlCommand.CommandText = $"SELECT NoiDung, CachHienThi FROM ThongBao WHERE DoiTuongNhanThongBao = N'{doiTuong}' AND NgayBatDau <= @CurrentDate AND NgayKetThuc >= @CurrentDate";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@CurrentDate", currentDate);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string nd = reader["NoiDung"].ToString();
                    string cachHienThi = reader["CachHienThi"].ToString();

                    if (cachHienThi == "Tin Nhắn")
                    {
                        Task task = new Task(() =>
                        {
                            Thread.Sleep(2000);
                            Message ms = new Message(sttTb++, "Hệ Thống", nd, sobuoi: 0);
                            ms.ShowDialog(); Thread.Sleep(3000);
                        });
                        task.Start();
                    }
                    if (cachHienThi == "Slide") { lb_ThongBao.Text = nd; StartTextAnimation(); }

                    if (cachHienThi == "Cả Hai")
                    {
                        Task task = new Task(() =>
                        {
                            Thread.Sleep(2000);
                            Message ms = new Message(sttTb++, "Hệ Thống", nd, sobuoi: 0);
                            ms.ShowDialog(); Thread.Sleep(3000);
                        });
                        task.Start();
                        lb_ThongBao.Text = nd;
                        StartTextAnimation();
                    }
                }

                reader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        void getAllTB()
        {
            tbSinhVien("Tất cả");
        }
        void tb(int Index, string senderName, string message)
        {
            Task task = new Task(() =>
            {
                Message messag = new Message(Index, senderName, message);
                messag.ShowDialog();

            });
            task.Start();
        }
        private void btnHoSoSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.HoSoSinhVien(quyenhan, username), sender);
        }
        private void btnHoSoTamTru_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.HoSoTamTru(username, quyenhan), sender);
        }

        private void btnDanhSachLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.FrmLop(), sender);
        }

        private void btnDanhSachKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.Khoa(), sender);
        }

        private void btnDiemRenLuyen_Click(object sender, EventArgs e)
        {
            if (btnNhapDiem.Visible == false)
            {
                btnXemDiem.Visible = true;
                btnNhapDiem.Visible = true;
            }
            else
            {
                btnNhapDiem.Visible = false;
                btnXemDiem.Visible = false;
            }
        }

        private void btnDiaDanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.FrmDiaDanh(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.ThongKe(), sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CNTT12.10.2    Đồ án chuyên nghành    Nhóm 16");
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {

        }

        private void thoatLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableMenuAdmin();
            btnDangNhap.Text = "ĐĂNG NHẬP";
            lblTrangThaiDN.Text = "Bạn Chưa Đăng Nhập";
            thoatLogin.Text = "";
            lblTitle.Text = "HOME";
            btnCloseChildForm.Hide();
            panel4.Visible = false;
            linkdoimatkhau.Visible = false;

            if (activeForm != null)
            {
                activeForm.Close();
                //this.Hide();
            }
            if (btnNhapDiem.Visible == true)
            {
                btnNhapDiem.Visible = false;
                btnXemDiem.Visible = false;
            }
            Reset();
            LB1.Visible = true; LB2.Visible = true; PXB_LOGO.Visible = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (btnDangNhap.Text == "ĐĂNG NHẬP")
            {
                OpenChildFormLogin(new QLSV_DH.FrmLogin(SetValue), sender);
            }
            else if (btnDangNhap.Text == "MỞ LỚP HỌC")
            {
                OpenChildFormLogin(new QLSV_DH.FrmTaoLopDangKyHoc(), sender);
            }
            else if (btnDangNhap.Text == "ĐĂNG KÝ HỌC")
            {
                OpenChildFormLogin(new QLSV_DH.FrmSinhVienDangKyHoc(username), sender);
            }
            else if (btnDangNhap.Text == "ĐIỂM SV")
            {
                OpenChildFormLogin(new QLSV_DH.FrmGiangVienNhapDiemMonHoc(username), sender);
            }
            LB1.Visible = false; LB2.Visible = false; PXB_LOGO.Visible = false;
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.FrmNhapDiemRL(), sender);
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.FrmXemDiemRL(quyenhan, username), sender);
        }
        private void btnQLGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.FrmQLTaiKhoan(), sender);
        }

        private void btnQLGiangVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.FrmQLGiangVien(username, quyenhan), sender);
        }

        private void btnQLMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.FrmMonHoc(), sender);
        }

        private void btnQLDiem_Click(object sender, EventArgs e)
        {
            if (quyenhan == "Sinh Viên")
            {
                OpenChildForm(new QLSV_DH.FrmXemDiem(username), sender);
            }
            else if (quyenhan == "Giảng Viên")
            {
                OpenChildForm(new QLSV_DH.FrmQLDiem(), sender);
            }
            else if (quyenhan == "Quản Lý")
            {
                OpenChildForm(new QLSV_DH.FrmQLDiem(), sender);
            }
        }

        private void btnTBTL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.FrmTBTL(), sender);
        }

        private void btnXetHocBong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.FrmXetHocBong(), sender);
        }

        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.DiemDanh(), sender);
        }
        private void linkdoimatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmREGISTER frm = new FrmREGISTER(username);
            frm.ShowDialog();
        }

        private void btn_Notication_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLSV_DH.Frm_Notication(), sender);
        }
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (btnDangNhap.Text == "ĐĂNG NHẬP")
            {
                OpenChildFormLogin(new QLSV_DH.FrmLogin(SetValue), sender);
            }
            else if (btnDangNhap.Text == "MỞ LỚP HỌC")
            {
                OpenChildFormLogin(new QLSV_DH.FrmTaoLopDangKyHoc(), sender);
            }
            else if (btnDangNhap.Text == "ĐĂNG KÝ HỌC")
            {
                OpenChildFormLogin(new QLSV_DH.FrmSinhVienDangKyHoc(username), sender);
            }
            else if (btnDangNhap.Text == "ĐIỂM SV")
            {
                OpenChildFormLogin(new QLSV_DH.FrmGiangVienNhapDiemMonHoc(username), sender);
            }
            LB1.Visible = false; LB2.Visible = false; PXB_LOGO.Visible = false;
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
    }
}
