using System;
using System.Data;
using System.Windows.Forms;

namespace QLSV_DH
{
    public partial class FrmXemDiem : Form
    {
        private String MaSinhVien;
        public FrmXemDiem(String MaSV)
        {
            InitializeComponent();
            this.MaSinhVien = MaSV;
        }

        private void FrmXemDiem_Load(object sender, EventArgs e)
        {
            Sinhvien a = new Sinhvien();
            groupBox1.Text = "MSV: " + MaSinhVien + " (" + a.TenSinhVien(int.Parse(MaSinhVien)) + ")";
            DiemTBTL b = new DiemTBTL();
            dataGridView2.DataSource = b.XemDiemHe4BySinhVien(MaSinhVien);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XemDiemSV a = new XemDiemSV();
            if (radioButtonTatCa.Checked)
            {
                dataGridView1.DataSource = a.LoadTatCaDiemSV(MaSinhVien);
            }
            else if (radioTheoNHHK.Checked)
            {
                if (cbboxNamHoc.Text != "")
                {
                    dataGridView1.DataSource = a.LoadDiemSVTheoHocKy(MaSinhVien, cbboxNamHoc.Text);
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn");
            }
        }

        private void radioTheoNHHK_CheckedChanged(object sender, EventArgs e)
        {
            DiemRL drl = new DiemRL();
            DataTable ds = new DataTable();
            ds = drl.DanhsachnamhocSVXemDiem123(drl.NamNhapHoc(MaSinhVien));
            cbboxNamHoc.DataSource = ds;
            cbboxNamHoc.DisplayMember = "Nam";
            cbboxNamHoc.ValueMember = "HocKyThu";
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
