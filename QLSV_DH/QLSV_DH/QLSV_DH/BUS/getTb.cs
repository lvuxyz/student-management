using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_DH
{
    class getTb
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;


        string tbSinhVien()
        {
            string noiDung = "";
            sqlConnection = new SqlConnection(ConnectionString.connectionString);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();

            try
            {
                // Mở kết nối
                sqlConnection.Open();

                string query = "SELECT NoiDung FROM ThongBao WHERE DoiTuongNhanThongBao = @DoiTuong AND NgayBatDau <= GETDATE() AND NgayKetThuc >= GETDATE()";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DoiTuong", "Sinh Viên");

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    noiDung = reader["NoiDung"].ToString();

                    return noiDung;
                }

                reader.Close();
            }
            catch { return noiDung = null; }
            finally
            {
                // Đóng kết nối
                sqlConnection.Close();
            }
            return noiDung = null;
        }
    }
}
