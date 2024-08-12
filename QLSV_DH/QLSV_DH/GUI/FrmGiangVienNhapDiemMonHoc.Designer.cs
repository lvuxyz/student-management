namespace QLSV_DH
{
    partial class FrmGiangVienNhapDiemMonHoc
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbboxLopHocDangDay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnloadsv = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.groupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblDuongDanFile = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDuongDan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.simpleButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatExCel = new Guna.UI2.WinForms.Guna2Button();
            this.simpleButton2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSV,
            this.HoTen,
            this.Lop,
            this.DiemKT1,
            this.DiemKT2,
            this.DiemThi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(36, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 621);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // MSV
            // 
            this.MSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSV.DataPropertyName = "MaSinhVien";
            this.MSV.HeaderText = "Mã Sinh Viên";
            this.MSV.MinimumWidth = 6;
            this.MSV.Name = "MSV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "Hoten";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // Lop
            // 
            this.Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lop.DataPropertyName = "TenLop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            // 
            // DiemKT1
            // 
            this.DiemKT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemKT1.DataPropertyName = "Diem1";
            this.DiemKT1.HeaderText = "Điểm Chuyên Cần";
            this.DiemKT1.MinimumWidth = 6;
            this.DiemKT1.Name = "DiemKT1";
            // 
            // DiemKT2
            // 
            this.DiemKT2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemKT2.DataPropertyName = "Diem2";
            this.DiemKT2.HeaderText = "Điểm giữa kì";
            this.DiemKT2.MinimumWidth = 6;
            this.DiemKT2.Name = "DiemKT2";
            // 
            // DiemThi
            // 
            this.DiemThi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.HeaderText = "Điểm Thi";
            this.DiemThi.MinimumWidth = 6;
            this.DiemThi.Name = "DiemThi";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DS CÁC LỚP HỌC :";
            // 
            // cbboxLopHocDangDay
            // 
            this.cbboxLopHocDangDay.BackColor = System.Drawing.Color.Transparent;
            this.cbboxLopHocDangDay.BorderRadius = 10;
            this.cbboxLopHocDangDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxLopHocDangDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxLopHocDangDay.FocusedColor = System.Drawing.Color.Empty;
            this.cbboxLopHocDangDay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxLopHocDangDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbboxLopHocDangDay.FormattingEnabled = true;
            this.cbboxLopHocDangDay.ItemHeight = 30;
            this.cbboxLopHocDangDay.Location = new System.Drawing.Point(160, 46);
            this.cbboxLopHocDangDay.Name = "cbboxLopHocDangDay";
            this.cbboxLopHocDangDay.Size = new System.Drawing.Size(332, 36);
            this.cbboxLopHocDangDay.TabIndex = 2;
            // 
            // btnloadsv
            // 
            this.btnloadsv.BackColor = System.Drawing.Color.Transparent;
            this.btnloadsv.BorderRadius = 10;
            this.btnloadsv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnloadsv.ForeColor = System.Drawing.Color.White;
            this.btnloadsv.Image = global::QLSV_DH.Properties.Resources.icons8_ok_20;
            this.btnloadsv.Location = new System.Drawing.Point(515, 51);
            this.btnloadsv.Name = "btnloadsv";
            this.btnloadsv.Size = new System.Drawing.Size(98, 31);
            this.btnloadsv.TabIndex = 3;
            this.btnloadsv.Text = "OK";
            this.btnloadsv.Click += new System.EventHandler(this.btnloadsv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BorderRadius = 10;
            this.groupBox1.Controls.Add(this.btnloadsv);
            this.groupBox1.Controls.Add(this.cbboxLopHocDangDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox1.Location = new System.Drawing.Point(36, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CÁC LỚP HỌC ĐANG QUẢN LÝ :";
            // 
            // groupBox6
            // 
            this.groupBox6.BorderRadius = 10;
            this.groupBox6.Controls.Add(this.lblDuongDanFile);
            this.groupBox6.Controls.Add(this.lblDuongDan);
            this.groupBox6.Controls.Add(this.simpleButton1);
            this.groupBox6.Controls.Add(this.btnXuatExCel);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox6.Location = new System.Drawing.Point(820, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(536, 91);
            this.groupBox6.TabIndex = 108;
            this.groupBox6.TabStop = false;
            // 
            // lblDuongDanFile
            // 
            this.lblDuongDanFile.BackColor = System.Drawing.Color.Transparent;
            this.lblDuongDanFile.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDuongDanFile.Location = new System.Drawing.Point(39, 46);
            this.lblDuongDanFile.Name = "lblDuongDanFile";
            this.lblDuongDanFile.Size = new System.Drawing.Size(3, 2);
            this.lblDuongDanFile.TabIndex = 106;
            this.lblDuongDanFile.Text = null;
            // 
            // lblDuongDan
            // 
            this.lblDuongDan.BackColor = System.Drawing.Color.Transparent;
            this.lblDuongDan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDuongDan.Location = new System.Drawing.Point(16, 46);
            this.lblDuongDan.Name = "lblDuongDan";
            this.lblDuongDan.Size = new System.Drawing.Size(15, 15);
            this.lblDuongDan.TabIndex = 105;
            this.lblDuongDan.Text = "=>";
            // 
            // simpleButton1
            // 
            this.simpleButton1.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.BorderRadius = 10;
            this.simpleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.simpleButton1.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Location = new System.Drawing.Point(16, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(155, 30);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "Chọn Đường Dẫn";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnXuatExCel
            // 
            this.btnXuatExCel.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatExCel.BorderRadius = 10;
            this.btnXuatExCel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatExCel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExCel.Location = new System.Drawing.Point(385, 51);
            this.btnXuatExCel.Name = "btnXuatExCel";
            this.btnXuatExCel.Size = new System.Drawing.Size(136, 28);
            this.btnXuatExCel.TabIndex = 22;
            this.btnXuatExCel.Text = "XUẤT EXCEL";
            this.btnXuatExCel.Click += new System.EventHandler(this.btnXuatExCel_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton2.BorderRadius = 10;
            this.simpleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.simpleButton2.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Location = new System.Drawing.Point(1122, 780);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(219, 36);
            this.simpleButton2.TabIndex = 109;
            this.simpleButton2.Text = "CẬP NHẬT";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmGiangVienNhapDiemMonHoc
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1380, 836);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGiangVienNhapDiemMonHoc";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "NHẬP ĐIỂM :)";
            this.Load += new System.EventHandler(this.FrmGiangVienNhapDiemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxLopHocDangDay;
        private Guna.UI2.WinForms.Guna2Button btnloadsv;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDuongDanFile;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDuongDan;
        private Guna.UI2.WinForms.Guna2Button simpleButton1;
        private Guna.UI2.WinForms.Guna2Button btnXuatExCel;
        private Guna.UI2.WinForms.Guna2Button simpleButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}