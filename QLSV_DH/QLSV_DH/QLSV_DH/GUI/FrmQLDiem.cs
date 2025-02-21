﻿using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QLSV_DH
{
    public partial class FrmQLDiem : Form
    {
        public FrmQLDiem()
        {
            InitializeComponent();
        }
        static String trangthai;
        static String chucnang;
        static int hocky;
        static String MMH;
        static int? MaDiemXoa = null;
        private static String NamHoc;
        private static String duongdan = null;
        private void FrmQLDiem_Load(object sender, EventArgs e)
        {
            DGV_VIEW.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            KhoaDT khoa = new KhoaDT();
            DataSet ds1 = new DataSet();
            ds1 = khoa.Loadkhoa();
            cbboxChonkhoa.DataSource = ds1.Tables[0];
            cbboxChonkhoa.DisplayMember = "Tenkhoa";
            cbboxChonkhoa.ValueMember = "Makhoa";

            btnCanCel.Enabled = false;
            btnOK.Enabled = false;
            duongdan = null;
        }

        private void cbboxChonlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            String t;
            t = cbboxChonlop.Text;
            if (t != "System.Data.DataRowView")
            {
                DiemRL drl = new DiemRL();
                DataTable ds = new DataTable();
                if (drl.KiemtratontaiSV(drl.Malop(t)) == true)
                {
                    ds = drl.DanhsachnamhocDiem(drl.NamNhapHoc(drl.Malop(t)));
                    cbboxNamHoc.DataSource = ds;
                    cbboxNamHoc.DisplayMember = "Nam";
                    cbboxNamHoc.ValueMember = "HocKy";
                    radioButtonHK1.Checked = false;
                    radioButtonHK2.Checked = false;
                }
                else
                {
                    MessageBox.Show("Không tồn tại sinh viên trong lớp nên không thể cập nhật các niên khóa học tập");
                }
            }
            cbboxMonHoc.DataSource = null;
        }

        private void cbboxChonkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            String t;
            t = cbboxChonkhoa.SelectedValue.ToString();
            if (t != "System.Data.DataRowView")
            {
                Lop dc = new Lop();
                DataSet ds = new DataSet();
                ds = dc.LoadLopselect(t);
                cbboxChonlop.DataSource = ds.Tables[0];
                cbboxChonlop.DisplayMember = "Tenlop";
                cbboxChonlop.ValueMember = "Malop";
            }
            cbboxMonHoc.DataSource = null;
        }

        private void cbboxNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbboxMonHoc.DataSource = null;
        }

        private void radioButtonHK1_CheckedChanged(object sender, EventArgs e)
        {
            String c = cbboxNamHoc.SelectedValue.ToString();
            hocky = int.Parse(c) - 1;

            KhoaDT a = new KhoaDT();
            MonHoc dc = new MonHoc();
            DataSet ds = new DataSet();
            ds = dc.LoadMonHocselect(hocky, a.Makhoa(cbboxChonkhoa.Text));
            cbboxMonHoc.DataSource = ds.Tables[0];
            cbboxMonHoc.DisplayMember = "TenMonHoc";
            cbboxMonHoc.ValueMember = "MaMonHoc";
        }

        private void radioButtonHK2_CheckedChanged(object sender, EventArgs e)
        {
            String c = cbboxNamHoc.SelectedValue.ToString();
            hocky = int.Parse(c);

            KhoaDT a = new KhoaDT();
            MonHoc dc = new MonHoc();
            DataSet ds = new DataSet();
            ds = dc.LoadMonHocselect(hocky, a.Makhoa(cbboxChonkhoa.Text));
            cbboxMonHoc.DataSource = ds.Tables[0];
            cbboxMonHoc.DisplayMember = "TenMonHoc";
            cbboxMonHoc.ValueMember = "MaMonHoc";
        }

        private void btnLoadDanhSach_Click(object sender, EventArgs e)
        {
            if (radioButtonXEMDIEM.Checked)
            {
                if (cbboxMonHoc.Text == "")
                {
                    MessageBox.Show("Bạn Chưa Chọn Môn Học");
                }
                else
                {
                    DGV_VIEW.DataSource = null;
                    DGV_VIEW.ColumnCount = 11;
                    DGV_VIEW.Columns[0].Name = "Mã Điểm";
                    DGV_VIEW.Columns[0].DataPropertyName = "MaSoDiem";
                    DGV_VIEW.Columns[1].Name = "MSV";
                    DGV_VIEW.Columns[1].DataPropertyName = "MSV";
                    DGV_VIEW.Columns[2].Name = "Họ Tên";
                    DGV_VIEW.Columns[2].DataPropertyName = "HoTen";
                    DGV_VIEW.Columns[3].Name = "Lần Học";
                    DGV_VIEW.Columns[3].DataPropertyName = "LanHoc";
                    DGV_VIEW.Columns[4].Name = "Năm Học";
                    DGV_VIEW.Columns[4].DataPropertyName = "NamHoc";
                    DGV_VIEW.Columns[5].Name = "Điểm TP1";
                    DGV_VIEW.Columns[5].DataPropertyName = "DiemChuyenCan";
                    DGV_VIEW.Columns[6].Name = "Điểm TP2";
                    DGV_VIEW.Columns[6].DataPropertyName = "DiemGiuaKi";
                    DGV_VIEW.Columns[7].Name = "Điểm Thi";
                    DGV_VIEW.Columns[7].DataPropertyName = "DiemThi";
                    DGV_VIEW.Columns[8].Name = "Điểm Tổng Kết";
                    DGV_VIEW.Columns[8].DataPropertyName = "DiemTongKet";
                    DGV_VIEW.Columns[9].Name = "Điểm Chữ";
                    DGV_VIEW.Columns[9].DataPropertyName = "DiemChu";
                    DGV_VIEW.Columns[10].Name = "Đánh Giá";
                    DGV_VIEW.Columns[10].DataPropertyName = "DanhGia";

                    Lop b = new Lop();
                    DiemMonHoc a = new DiemMonHoc();

                    DGV_VIEW.DataSource = a.XemDiemTheoLop(cbboxMonHoc.SelectedValue.ToString(), b.Malop(cbboxChonlop.Text));
                    trangthai = "Xem Điểm";
                    DGV_VIEW.ReadOnly = true;

                    btnCanCel.Enabled = false;
                    btnOK.Enabled = false;
                    btnXoaDiem.Enabled = true;
                    btnNhapDiem.Enabled = true;
                    chucnang = "";
                    lblThongBao.Text = "Here";
                    DGV_VIEW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            else if (radioButtonNHAPDIEM.Checked)
            {
                if (cbboxMonHoc.Text == "")
                {
                    MessageBox.Show("Bạn Chưa Chọn Môn Học");
                }
                else
                {
                    DGV_VIEW.DataSource = null;
                    DGV_VIEW.ColumnCount = 7;
                    DGV_VIEW.Columns[0].Name = "MSV";
                    DGV_VIEW.Columns[0].DataPropertyName = "MSV";
                    DGV_VIEW.Columns[1].Name = "Họ Tên";
                    DGV_VIEW.Columns[1].DataPropertyName = "HoTen";
                    DGV_VIEW.Columns[2].Name = "Lần Học";
                    DGV_VIEW.Columns[2].DataPropertyName = "LanHoc";
                    DGV_VIEW.Columns[3].Name = "Năm Học";
                    DGV_VIEW.Columns[3].DataPropertyName = "NamHoc";
                    DGV_VIEW.Columns[4].Name = "Điểm Chuyên Cần";
                    DGV_VIEW.Columns[4].DataPropertyName = "DiemChuyenCan";
                    DGV_VIEW.Columns[5].Name = "Điểm Giữa Kì";
                    DGV_VIEW.Columns[5].DataPropertyName = "DiemGiuaKi";
                    DGV_VIEW.Columns[6].Name = "Điểm Thi";
                    DGV_VIEW.Columns[6].DataPropertyName = "DiemThi";
                    Lop b = new Lop();
                    DiemMonHoc a = new DiemMonHoc();
                    DGV_VIEW.DataSource = a.NhapDiemTheoLop(cbboxMonHoc.SelectedValue.ToString(), b.Malop(cbboxChonlop.Text));
                    trangthai = "Nhập Điểm";
                    MMH = cbboxMonHoc.SelectedValue.ToString();
                    DGV_VIEW.ReadOnly = false;
                    String hk = "";
                    if (radioButtonHK1.Checked)
                    {
                        hk = "1";
                    }
                    else if (radioButtonHK2.Checked)
                    {
                        hk = "2";
                    }
                    NamHoc = cbboxNamHoc.Text + "_" + hk;
                    chucnang = "";
                    lblThongBao.Text = "Here";
                    btnCanCel.Enabled = false;
                    btnOK.Enabled = false;
                    btnXoaDiem.Enabled = true;
                    btnNhapDiem.Enabled = true;
                    DGV_VIEW.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                }
            }
            else
            {
                MessageBox.Show("HÃY LỰA CHỌN NHẬP ĐIỂM HOẶC XEM ĐIỂM");
            }
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (trangthai == "Nhập Điểm")
            {
                String tmh = "";
                KhoaDT b = new KhoaDT();
                DiemMonHoc a = new DiemMonHoc();
                if (trangthai == "Nhập Điểm")
                {
                    tmh = a.TenMonHoc(cbboxMonHoc.SelectedValue.ToString());
                }
                lblThongBao.Text = "Nhập/Sửa Điểm Cho Môn " + tmh;
                btnOK.Enabled = true;
                btnCanCel.Enabled = true;
                chucnang = "Nhập Điểm";

                btnNhapDiem.Enabled = false;
                btnXoaDiem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Chức Năng Này Chỉ Hoạt Động Ở Mục Nhập Điểm");
            }
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "Here";
            btnOK.Enabled = false;
            btnCanCel.Enabled = false;

            btnNhapDiem.Enabled = true;
            btnXoaDiem.Enabled = true;
            MaDiemXoa = null;
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            if (trangthai == "Nhập Điểm")
            {
                MessageBox.Show("Chức Năng Này Chỉ Hoạt Động Trong Trạng Thái Xem Điểm");
            }
            else
            {
                lblThongBao.Text = "Bạn Đang Chọn Chức Năng Sửa Điểm";
                btnOK.Enabled = true;
                btnCanCel.Enabled = true;
                chucnang = "Sửa Điểm";

                btnNhapDiem.Enabled = true;
                btnXoaDiem.Enabled = true;
            }
        }

        private void btnXoaDiem_Click(object sender, EventArgs e)
        {
            if (trangthai == "Nhập Điểm")
            {
                MessageBox.Show("Chức Năng Này Chỉ Hoạt Động Trong Trạng Thái Xem Điểm");
            }
            else if (trangthai == "Xem Điểm")
            {
                if (MaDiemXoa == null)
                {
                    MessageBox.Show("Bạn Cần Chỉ Định Một Đối Tượng Nào Đó");
                }
                else
                {
                    lblThongBao.Text = "Bạn Đang Chọn Chức Năng Xóa Điểm Ở Vị Tí MSĐ = " + MaDiemXoa;
                    btnOK.Enabled = true;
                    btnCanCel.Enabled = true;
                    chucnang = "Xóa Điểm";
                    btnXoaDiem.Enabled = false;
                    btnNhapDiem.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Chức Năng Này Chỉ Hoạt Động Trong Trạng Thái Xem Điểm");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chucnang == "Nhập Điểm")
            {
                if (trangthai == "Nhập Điểm")
                {
                    try
                    {
                        DiemMonHoc a = new DiemMonHoc();
                        for (int i = 0; i < DGV_VIEW.Rows.Count; i++)
                        {
                            String MSV = DGV_VIEW.Rows[i].Cells[0].Value.ToString();
                            String HoTen = DGV_VIEW.Rows[i].Cells[1].Value.ToString();
                            int lanhoc;
                            if (DGV_VIEW.Rows[i].Cells[2].Value.ToString() != "")
                            {
                                lanhoc = int.Parse(DGV_VIEW.Rows[i].Cells[2].Value.ToString());
                            }
                            else
                            {
                                lanhoc = 1;
                            }
                            double? DiemChuyenCan = null;
                            double? DiemGiuaKi = null;
                            double? DiemThi = null;
                            double? DiemTongKet = null;
                            double? DiemHe4 = null;
                            String DiemChu = null;
                            String DanhGia = null;
                            String NH = null;

                            if (DGV_VIEW.Rows[i].Cells[3].Value.ToString() != "")
                            {
                                NH = DGV_VIEW.Rows[i].Cells[3].Value.ToString();
                            }
                            else
                            {
                                NH = NamHoc;
                            }

                            if (DGV_VIEW.Rows[i].Cells[4].Value.ToString() != "")
                            {
                                DiemChuyenCan = double.Parse(DGV_VIEW.Rows[i].Cells[4].Value.ToString());
                            }
                            if (DGV_VIEW.Rows[i].Cells[5].Value.ToString() != "")
                            {
                                DiemGiuaKi = double.Parse(DGV_VIEW.Rows[i].Cells[5].Value.ToString());
                            }
                            if (DGV_VIEW.Rows[i].Cells[6].Value.ToString() != "")
                            {
                                DiemThi = double.Parse(DGV_VIEW.Rows[i].Cells[6].Value.ToString());
                            }

                            if (DiemChuyenCan != null && DiemGiuaKi != null && DiemThi != null)
                            {
                                if (DiemChuyenCan > 10 || DiemGiuaKi > 10 || DiemThi > 10)
                                {
                                    MessageBox.Show("Cảnh Báo. Điểm Nhập Ko Hợp Lệ: MSV:" + MSV);
                                    break;
                                }
                                DiemTongKet = (((DiemChuyenCan + DiemGiuaKi) / 2) * 0.4) + (DiemThi * 0.6);
                                String str = String.Format("{0:00.0}", DiemTongKet);
                                DiemTongKet = double.Parse(str);
                                if (DiemTongKet <= 10.0 && DiemTongKet >= 8.5)
                                {
                                    DiemChu = "A";
                                    DiemHe4 = 4.0;
                                }
                                else if (DiemTongKet >= 8.0 && DiemTongKet <= 8.4)
                                {
                                    DiemChu = "B+";
                                    DiemHe4 = 3.5;
                                }
                                else if (DiemTongKet >= 7.0 && DiemTongKet <= 7.9)
                                {
                                    DiemChu = "B";
                                    DiemHe4 = 3.0;
                                }
                                else if (DiemTongKet >= 6.0 && DiemTongKet <= 6.4)
                                {
                                    DiemChu = "C";
                                    DiemHe4 = 2.0;
                                }
                                else if (DiemTongKet >= 6.5 && DiemTongKet <= 6.9)
                                {
                                    DiemChu = "C+";
                                    DiemHe4 = 2.5;
                                }
                                else if (DiemTongKet >= 5.0 && DiemTongKet <= 5.9)
                                {
                                    DiemChu = "D+";
                                    DiemHe4 = 1.5;
                                }
                                else if (DiemTongKet >= 4.0 && DiemTongKet <= 4.9)
                                {
                                    DiemChu = "D";
                                    DiemHe4 = 1.0;
                                }
                                else if (DiemTongKet < 4.0)
                                {
                                    DiemChu = "F";
                                    DiemHe4 = 0;
                                }
                                else
                                {
                                    MessageBox.Show("Cảnh Báo. Điểm Nhập Ko Hợp Lệ: MSV:" + MSV);
                                    break;
                                }

                                if (DiemChu == "A" || DiemChu == "B" || DiemChu == "B+" || DiemChu == "C+" || DiemChu == "C" || DiemChu == "D+" || DiemChu == "D")
                                {
                                    DanhGia = "Đạt";
                                }
                                else
                                {
                                    DanhGia = "Chưa Đạt";
                                }
                            }
                            if (a.checkDaCoDiem(MSV, MMH, lanhoc, NH) == true)
                            {
                                a.insertDiem(MSV, MMH, lanhoc, NH, DiemChuyenCan, DiemGiuaKi, DiemThi, DiemTongKet, DiemChu, DiemHe4, DanhGia);
                            }
                            else
                            {
                                a.updateDiem(MSV, MMH, lanhoc, DiemChuyenCan, DiemGiuaKi, DiemThi, DiemTongKet, DiemChu, DiemHe4, DanhGia);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Done :)");
                    chucnang = "";
                    lblThongBao.Text = "Here";
                    btnCanCel.Enabled = false;
                    btnOK.Enabled = false;
                    btnXoaDiem.Enabled = true;
                    btnNhapDiem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Chức Năng Này chỉ hoạt động khi bạn chọn Nhập Điểm");
                }
            }
            else if (chucnang == "Xóa Điểm")
            {
                DiemMonHoc a = new DiemMonHoc();
                a.XoaDiem(MaDiemXoa);
                MessageBox.Show("Done :)");
                btnXoaDiem.Enabled = true;
                btnOK.Enabled = false;
                btnCanCel.Enabled = false;
                chucnang = "";
            }
            else
            {
                MessageBox.Show("Ngoài Tầm Kiểm Soát ...");
            }
        }

        private void radioButtonNHAPDIEM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (trangthai == "Xem Điểm")
            {
                if (DGV_VIEW.Rows.Count != 0)
                {
                    MaDiemXoa = int.Parse(DGV_VIEW.CurrentRow.Cells[0].Value.ToString());
                }
               
            }
        }
        private void export2Excel(DataGridView g, String duongdan)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan);
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnXuatExCel_Click(object sender, EventArgs e)
        {
            if (DGV_VIEW.Rows.Count == 0)
            {
                MessageBox.Show("Ko co gi de xuat");
            }
            else
            {
                if (duongdan == null)
                {
                    MessageBox.Show("Bạn Hãy Chọn Nơi Lưu File");
                }
                else
                {
                    if (File.Exists(duongdan))
                    {
                        MessageBox.Show("Đã Có Tên File Này Rồi. Bạn Nên Chọn Tên Khác");
                    }
                    else
                    {
                        FrmLoad a = new FrmLoad(DGV_VIEW, duongdan);
                        a.Show();
                        duongdan = null;
                        lblDuongDanFile.Text = "";
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Title = "Select Location";
                dlg.Filter = "Excel Worksheets|*.xlsx";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    duongdan = dlg.FileName.ToString();
                    lblDuongDanFile.Text = duongdan;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGV_VIEW.ClearSelection();
        }
    }
}
