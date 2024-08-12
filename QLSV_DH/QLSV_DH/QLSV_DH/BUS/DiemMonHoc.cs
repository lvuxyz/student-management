using System;
using System.Data;
using System.Data.SqlClient;


namespace QLSV_DH
{
    class DiemMonHoc
    {
        public DataTable XemDiemTheoLop(String MMH, int Malop)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "select DiemMonHoc.MaSoDiem,SinhVien.MSV,SinhVien.HoTen,DiemMonHoc.LanHoc,DiemMonHoc.NamHoc,DiemMonHoc.DiemChuyenCan,DiemMonHoc.DiemGiuaKi,DiemMonHoc.DiemThi,DiemMonHoc.DiemTongKet,DiemMonHoc.DiemChu,DiemMonHoc.DanhGia from((DiemMonHoc inner join SinhVien on SinhVien.MSV = DiemMonHoc.MaSV)inner join MonHoc on DiemMonHoc.MaMH = MonHoc.MaMonHoc) where MonHoc.MaMonHoc = @MMH and SinhVien.Malop=@malop order by SinhVien.MSV";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@MMH", MMH));
                cmd.Parameters.Add(new SqlParameter("@malop", Malop));
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                Adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        public void XoaDiem(int? Madiem)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "delete from DiemMonHoc where MaSoDiem=@Madiem";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@Madiem", Madiem));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable NhapDiemTheoLop(String MMH, int Malop)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "SELECT SinhVien.MSV,SinhVien.Hoten,DiemMonHoc.LanHoc,DiemMonHoc.NamHoc,DiemMonHoc.DiemChuyenCan,DiemMonHoc.DiemGiuaKi,DiemMonHoc.DiemThi FROM SinhVien LEFT OUTER JOIN DiemMonHoc ON DiemMonHoc.MaSV = SinhVien.MSV and DiemMonHoc.MaMH = @MMH where SinhVien.Malop = @malop order by SinhVien.MSV ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@MMH", MMH));
                cmd.Parameters.Add(new SqlParameter("@malop", Malop));
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                Adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        public String TenMonHoc(String MMH)
        {
            String TMH = "";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "Select TenMonHoc from MonHoc where MaMonHoc=@MMH";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@MMH", MMH));
                TMH = (String)cmd.ExecuteScalar();
                con.Close();
            }
            return TMH;
        }

        public int Makhoa(String MMH)
        {
            int Makhoa;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "Select MaKhoa from MonHoc where MaMonHoc=@MMH";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@MMH", MMH));
                Makhoa = (int)cmd.ExecuteScalar();
                con.Close();
            }
            return Makhoa;
        }


        public void insertDiem(String MSV, String MMH, int LanHoc, String NamHoc, double? DiemChuyenCan, double? DiemGiuaKi, double? DiemThi, double? DiemTongKet, String DiemChu, double? DiemHe4, String DanhGia)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "insert into DiemMonHoc(MaSV,MaMH,LanHoc,NamHoc,DiemChuyenCan,DiemGiuaKi,DiemThi,DiemTongKet,DiemChu,DiemHe4,DanhGia) values(@MSV,@MMH,@LanHoc,@NamHoc,@DiemChuyenCan,@DiemGiuaKi,@DiemThi,@DiemTongKet,@DiemChu,@DiemHe4,@DanhGia)";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (String.IsNullOrEmpty(MSV))
                {
                    cmd.Parameters.Add(new SqlParameter("@MSV", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@MSV", MSV));
                }
                if (String.IsNullOrEmpty(MMH))
                {
                    cmd.Parameters.Add(new SqlParameter("@MMH", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@MMH", MMH));
                }
                cmd.Parameters.Add(new SqlParameter("@LanHoc", LanHoc));
                cmd.Parameters.Add(new SqlParameter("@NamHoc", NamHoc));
                if (DiemChuyenCan == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemChuyenCan", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemChuyenCan", DiemChuyenCan));
                }
                if (DiemGiuaKi == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemGiuaKi", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemGiuaKi", DiemGiuaKi));
                }
                if (DiemThi == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemThi", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemThi", DiemThi));
                }
                if (DiemTongKet == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemTongKet", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemTongKet", DiemTongKet));
                }
                if (DiemChu == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemChu", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemChu", DiemChu));
                }
                if (DiemHe4 == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemHe4", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemHe4", DiemHe4));
                }
                if (DanhGia == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DanhGia", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DanhGia", DanhGia));
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void updateDiem(String MSV, String MMH, int LanHoc, double? DiemChuyenCan, double? DiemGiuaKi, double? DiemThi, double? DiemTongKet, String DiemChu, double? DiemHe4, String DanhGia)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                String sql = "update DiemMonHoc set DiemChuyenCan=@DiemChuyenCan,DiemGiuaKi=@DiemGiuaKi,DiemThi=@DiemThi,DiemTongKet=@DiemTongKet,DiemChu=@DiemChu,DiemHe4=@DiemHe4,DanhGia=@DanhGia where MaSV=@MSV and MaMH=@MMH and LanHoc=@LanHoc";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (String.IsNullOrEmpty(MSV))
                {
                    cmd.Parameters.Add(new SqlParameter("@MSV", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@MSV", MSV));
                }
                if (String.IsNullOrEmpty(MMH))
                {
                    cmd.Parameters.Add(new SqlParameter("@MMH", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@MMH", MMH));
                }
                cmd.Parameters.Add(new SqlParameter("@LanHoc", LanHoc));
                if (DiemChuyenCan == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemChuyenCan", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemChuyenCan", DiemChuyenCan));
                }
                if (DiemGiuaKi == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemGiuaKi", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemGiuaKi", DiemGiuaKi));
                }
                if (DiemThi == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemThi", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemThi", DiemThi));
                }
                if (DiemTongKet == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemTongKet", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemTongKet", DiemTongKet));
                }
                if (DiemChu == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemChu", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemChu", DiemChu));
                }
                if (DiemHe4 == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemHe4", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DiemHe4", DiemHe4));
                }
                if (DanhGia == null)
                {
                    cmd.Parameters.Add(new SqlParameter("@DanhGia", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@DanhGia", DanhGia));
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Boolean checkDaCoDiem(String MSV, String MMH, int lanhoc, String NamHoc)
        {
            SqlConnection con = new SqlConnection(ConnectionString.connectionString);
            con.Open();
            String sql = "SELECT COUNT(*) FROM [QLSV].[dbo].[DiemMonHoc] where MaSV=@MSV and MaMH=@MMH and LanHoc=@lanhoc and NamHoc=@NamHoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(new SqlParameter("@MSV", MSV));
            cmd.Parameters.Add(new SqlParameter("@MMH", MMH));
            cmd.Parameters.Add(new SqlParameter("@lanhoc", lanhoc));
            cmd.Parameters.Add(new SqlParameter("@NamHoc", NamHoc));
            int x = (int)cmd.ExecuteScalar();
            //int x = (int)cmd.ExecuteNonQuery(); 
            con.Close();
            if (x == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
