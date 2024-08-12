using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLSV_DH
{
    public partial class DiemDanh : Form
    {
        public DiemDanh()
        {
            InitializeComponent();
        }

        private void btn_EndDiemDanh_Click(object sender, EventArgs e)
        {
            string maMonHoc = MaMonHoc;
            string ngayDanhGia = cbx_Date.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow row in dgv_SV.Rows)
                {
                    bool status = (bool)row.Cells["chk_DiemDanh"].Value;
                    string msv = row.Cells["MSV"].Value.ToString();
                    string tenLop = row.Cells["TenLop"].Value.ToString();

                    string insertQuery = "INSERT INTO DiemDanh (MSV, TenLop, MaMonHoc, NgayDanhGia, Status) " +
                                         "VALUES (@msv, @tenLop, @maMonHoc, @ngayDanhGia, @status)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@msv", msv);
                        command.Parameters.AddWithValue("@tenLop", tenLop);
                        command.Parameters.AddWithValue("@maMonHoc", maMonHoc);
                        command.Parameters.AddWithValue("@ngayDanhGia", ngayDanhGia);
                        command.Parameters.AddWithValue("@status", status);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Lưu Điểm Danh thành công !");
            }
        }

        private void DiemDanh_Load(object sender, EventArgs e)
        {
            KhoaDT khoa = new KhoaDT();
            DataSet ds1 = new DataSet();
            ds1 = khoa.Loadkhoa();
            cbx_Khoa.DataSource = ds1.Tables[0];
            cbx_Khoa.DisplayMember = "Tenkhoa";
            cbx_Khoa.ValueMember = "Makhoa";
        }

        private void cbx_Khoa_SelectedIndexChanged(object sender, EventArgs e)
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
            cbx_MonHoc.DataSource = null;
        }

        string Tenlop = "";
        string MaMonHoc = "";

        private void btn_Load_Click(object sender, EventArgs e)
        {
            string connectionString = ConnectionString.connectionString;
            string query = "SELECT SinhVien.MSV, SinhVien.Hoten, DiemMonHoc.DiemChuyenCan, Lop.Tenlop " +
                           "FROM DiemMonHoc " +
                           "JOIN SinhVien ON DiemMonHoc.MaSV = SinhVien.MSV " +
                           "JOIN MonHoc ON DiemMonHoc.MaMH = MonHoc.MaMonHoc " +
                           "JOIN Lop ON SinhVien.Malop = Lop.Malop " +
                           $"WHERE Lop.Tenlop = '{Tenlop}' AND MonHoc.MaMonHoc = '{MaMonHoc}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    dgv_SV.DataSource = dataTable; // Gán kết quả vào DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            CheckAll(dgv_SV);
        }
        void CheckAll(DataGridView dgv)
        {
            // Thiết lập trạng thái ban đầu của cột "chk_DiemDanh" là true cho tất cả các hàng
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["chk_DiemDanh"] as DataGridViewCheckBoxCell;
                cell.Value = true;
            }
        }
        public SqlConnection getConnect()
        {
            string connectionString = null;
            connectionString = ConnectionString.connectionString;
            return new SqlConnection(connectionString);
        }

        private void cbx_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_lop.Text != "System.Data.DataRowView")
            {
                Tenlop = cbx_lop.Text;
                // Thực hiện truy vấn SQL để lấy toàn bộ danh sách môn học
                string query = "SELECT TenMonHoc FROM MonHoc";
                using (SqlConnection connection = getConnect())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            cbx_MonHoc.Items.Clear();
                            while (reader.Read())
                            {
                                // Thêm môn học vào ComboBox MonHoc
                                cbx_MonHoc.Items.Add(reader["TenMonHoc"].ToString());
                            }
                        }
                    }
                }
                cbx_MonHoc.StartIndex = 0;
            }

        }

        private string connectionString = ConnectionString.connectionString;
        public string GetMaMonHocByTenMonHoc(string tenMonHoc)
        {
            string maMonHoc = null;
            string query = "SELECT MaMonHoc FROM MonHoc WHERE TenMonHoc = @tenMonHoc";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tenMonHoc", tenMonHoc);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maMonHoc = reader["MaMonHoc"].ToString();
                        }
                    }
                }
            }

            return maMonHoc;
        }

        private void cbx_MonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_MonHoc.Text != "System.Data.DataRowView")
            {
                MaMonHoc = GetMaMonHocByTenMonHoc(cbx_MonHoc.Text);
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExportEX_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1] as Excel.Worksheet;
                if (excelWorksheet == null)
                { MessageBox.Show("Không thể tạo WorkSheet."); return; }
                excelWorksheet.Cells[1, 1] = "Đi học";
                excelWorksheet.Cells[1, 2] = "MSV";
                excelWorksheet.Cells[1, 3] = "Họ và tên";
                excelWorksheet.Cells[1, 4] = "Điểm chuyên cần";
                excelWorksheet.Cells[1, 5] = "Tên lớp";

                Excel.Range headerRange = excelWorksheet.Range[excelWorksheet.Cells[1, 1], excelWorksheet.Cells[1, 5]];
                headerRange.Interior.Color = System.Drawing.Color.FromArgb(155, 194, 230);
                headerRange.Font.Bold = true;

                for (int i = 0; i < dgv_SV.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_SV.Columns.Count; j++)
                    {
                        excelWorksheet.Cells[i + 2, j + 1] = dgv_SV.Rows[i].Cells[j].Value.ToString();
                    }
                    if (dgv_SV.Rows[i].Cells[0].Value.ToString().StartsWith("F") || Convert.ToDouble(dgv_SV.Rows[i].Cells[3].Value) < 5)
                    {
                        Excel.Range redFontRange = excelWorksheet.Range[excelWorksheet.Cells[i + 2, 1], excelWorksheet.Cells[i + 2, 5]];
                        redFontRange.Font.Color = System.Drawing.Color.Red;
                    }
                }
                int rowCount = dgv_SV.Rows.Count;
                int uncheckedRowCount = 0;

                for (int i = 0; i < rowCount; i++)
                {
                    DataGridViewCheckBoxCell checkBoxCell = dgv_SV.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null && !(bool)checkBoxCell.Value) { uncheckedRowCount++; }
                }

                Excel.Range lastRowRange = excelWorksheet.Cells[excelWorksheet.UsedRange.Rows.Count + 1, 1];
                lastRowRange = lastRowRange.Resize[1, 5]; // Gộp 5 cột thành một
                lastRowRange.Merge(); // Gộp ô
                if (uncheckedRowCount > 0) { lastRowRange.Value = $"Vắng: {uncheckedRowCount} Sinh Viên"; lastRowRange.Interior.Color = System.Drawing.Color.FromArgb(244, 176, 132); }
                else { lastRowRange.Value = "Đi học đầy đủ"; lastRowRange.Interior.Color = System.Drawing.Color.FromArgb(0, 176, 80); }
                lastRowRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                Excel.Range excelRange = excelWorksheet.UsedRange;
                excelRange.Columns.AutoFit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelRange);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
            catch { }

        }

        private void dgv_SV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowCount = dgv_SV.Rows.Count;
                int uncheckedRowCount = 0;

                for (int i = 0; i < rowCount; i++)
                {
                    DataGridViewCheckBoxCell checkBoxCell = dgv_SV.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                    if (checkBoxCell != null && !(bool)checkBoxCell.Value) { uncheckedRowCount++; }
                }
                if (uncheckedRowCount > 0) { lb_Vang.Text = $@"Vắng: {uncheckedRowCount} Sinh Viên"; lb_Vang.ForeColor = Color.Red; }
            }
            catch
            {
            }

        }
    }
}
