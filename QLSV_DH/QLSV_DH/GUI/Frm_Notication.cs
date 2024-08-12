using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLSV_DH
{
    public partial class Frm_Notication : Form
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;
        public Frm_Notication()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            Load_dgv();
        }
        private void InitializeDatabaseConnection()
        {
            sqlConnection = new SqlConnection(ConnectionString.connectionString);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
        }
        private void Frm_Notication_Load(object sender, EventArgs e)
        {
        }
        void Load_dgv()
        {

            // Chuỗi kết nối từ class ConnectionString của bạn
            string connectionString = ConnectionString.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Câu truy vấn SQL để lấy dữ liệu từ bảng "ThongBao"
                string query = "SELECT * FROM ThongBao";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Tạo một SqlDataAdapter để đổ dữ liệu vào DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                    adapter.Fill(dataTable);

                    // Đặt DataGridView.DataSource là DataTable để hiển thị dữ liệu trên DataGridView
                    dgv_TB.DataSource = dataTable;
                }

                // Đóng kết nối
                connection.Close();
            }
        }
        string Tenlop = "";

        private void cbx_lop_MouseClick(object sender, MouseEventArgs e)
        {
            string t;
            t = cbx_Khoa.SelectedValue.ToString();
            if (t != "System.Data.DataRowView")
            {
                Lop dc = new Lop();
                DataSet ds = new DataSet();
                ds = dc.LoadLopselect(t);
                cbx_lop.DataSource = ds.Tables[0];
                cbx_lop.DisplayMember = "Tenlop";
                cbx_lop.ValueMember = "Malop";
            }
        }



        private void cbx_Khoa_MouseClick(object sender, MouseEventArgs e)
        {
            KhoaDT khoa = new KhoaDT();
            DataSet ds1 = new DataSet();
            ds1 = khoa.Loadkhoa();
            cbx_Khoa.DataSource = ds1.Tables[0];
            cbx_Khoa.DisplayMember = "Tenkhoa";
            cbx_Khoa.ValueMember = "Makhoa";
            cbx_lop.DataSource = null;
        }

        private void btn_TaoTB_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                DateTime ngayBatDau = DateTime.Parse(date_Start.Text);
                DateTime ngayKetThuc = DateTime.Parse(date_Stop.Text);
                string doiTuongNhanThongBao = cbx_doiTuongNhan.Text;
                string loaiThongBao = cbx_loaiThongBao.Text;
                string khoa = cbx_Khoa.Text;
                string lop = cbx_lop.Text;
                string cachHienThi = "";
                if (rdo_tinNhan.Checked) { cachHienThi = "Tin Nhắn"; }
                else if (rd_slide.Checked) { cachHienThi = "Slide"; }
                else { cachHienThi = "Cả Hai"; }
                string noiDung = txt_NoiDungTB.Text;

                // Tạo lệnh SQL để thêm dữ liệu
                sqlCommand.CommandText = "INSERT INTO ThongBao (NgayBatDau, NgayKetThuc, DoiTuongNhanThongBao, LoaiThongBao, Khoa, Lop, CachHienThi, NoiDung) " +
                                         "VALUES (@NgayBatDau, @NgayKetThuc, @DoiTuongNhanThongBao, @LoaiThongBao, @Khoa, @Lop, @CachHienThi, @NoiDung)";
                sqlCommand.Parameters.Clear(); // Xóa các tham số trước khi thêm lại

                sqlCommand.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                sqlCommand.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                sqlCommand.Parameters.AddWithValue("@DoiTuongNhanThongBao", doiTuongNhanThongBao);
                sqlCommand.Parameters.AddWithValue("@LoaiThongBao", loaiThongBao);
                sqlCommand.Parameters.AddWithValue("@Khoa", khoa);
                sqlCommand.Parameters.AddWithValue("@Lop", lop);
                sqlCommand.Parameters.AddWithValue("@CachHienThi", cachHienThi);
                sqlCommand.Parameters.AddWithValue("@NoiDung", noiDung);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }


            Load_dgv();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa những thông báo đã chọn ?", "Xóa Thông báo đã chọn", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                // Tạo một danh sách để lưu trữ các ID của các dòng đã được chọn
                List<int> selectedIDs = new List<int>();

                // Lặp qua các dòng trong DataGridView
                foreach (DataGridViewRow row in dgv_TB.Rows)
                {
                    // Kiểm tra xem checkbox trong hàng hiện tại có được đánh dấu hay không
                    DataGridViewCheckBoxCell checkboxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                    if (checkboxCell != null && Convert.ToBoolean(checkboxCell.FormattedValue))
                    {
                        // Lấy giá trị của cột ID trong hàng hiện tại và thêm nó vào danh sách
                        int id = Convert.ToInt32(row.Cells[1].FormattedValue);
                        selectedIDs.Add(id);
                    }
                }

                // Mở kết nối đến cơ sở dữ liệu
                sqlConnection.Open();

                // Lặp qua danh sách các ID đã chọn và xóa dữ liệu tương ứng
                foreach (int id in selectedIDs)
                {
                    try
                    {
                        sqlCommand.CommandText = "DELETE FROM ThongBao WHERE ID = @ID";
                        sqlCommand.Parameters.Clear();
                        sqlCommand.Parameters.AddWithValue("@ID", id);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dòng có ID=" + id + ": " + ex.Message);
                    }
                }

                // Đóng kết nối đến cơ sở dữ liệu
                sqlConnection.Close();

                // Hiển thị thông báo về số lượng dòng đã xóa
                MessageBox.Show("Đã xóa: " + selectedIDs.Count.ToString() + " Thông báo");

                // Cập nhật lại DataGridView sau khi xóa
                Load_dgv();
            }
            else if (result == DialogResult.Cancel)
            {
                // Không làm gì cả
            }


        }
    }
}
