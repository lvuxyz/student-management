namespace QLSV_DH
{
    partial class FrmNhapDiemRL
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
            this.cbboxChonkhoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbboxchonlop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamNhapHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.radioButtonHK1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonHK2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTongDiemRL = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbboxNamHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.groupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLoadSV = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbboxChonkhoa
            // 
            this.cbboxChonkhoa.BackColor = System.Drawing.Color.Transparent;
            this.cbboxChonkhoa.BorderRadius = 10;
            this.cbboxChonkhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxChonkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxChonkhoa.FocusedColor = System.Drawing.Color.Empty;
            this.cbboxChonkhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxChonkhoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbboxChonkhoa.FormattingEnabled = true;
            this.cbboxChonkhoa.ItemHeight = 30;
            this.cbboxChonkhoa.Location = new System.Drawing.Point(50, 61);
            this.cbboxChonkhoa.Name = "cbboxChonkhoa";
            this.cbboxChonkhoa.Size = new System.Drawing.Size(166, 36);
            this.cbboxChonkhoa.TabIndex = 0;
            this.cbboxChonkhoa.SelectedIndexChanged += new System.EventHandler(this.cbboxChonkhoa_SelectedIndexChanged);
            // 
            // cbboxchonlop
            // 
            this.cbboxchonlop.BackColor = System.Drawing.Color.Transparent;
            this.cbboxchonlop.BorderRadius = 10;
            this.cbboxchonlop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxchonlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxchonlop.FocusedColor = System.Drawing.Color.Empty;
            this.cbboxchonlop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxchonlop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbboxchonlop.FormattingEnabled = true;
            this.cbboxchonlop.ItemHeight = 30;
            this.cbboxchonlop.Location = new System.Drawing.Point(50, 103);
            this.cbboxchonlop.Name = "cbboxchonlop";
            this.cbboxchonlop.Size = new System.Drawing.Size(166, 36);
            this.cbboxchonlop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHOA :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "LỚP :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSV,
            this.HoTen,
            this.Malop,
            this.NamNhapHoc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(395, 20);
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
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(965, 810);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // MSV
            // 
            this.MSV.DataPropertyName = "MSV";
            this.MSV.HeaderText = "Mã SV";
            this.MSV.MinimumWidth = 6;
            this.MSV.Name = "MSV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "Hoten";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "Tenlop";
            this.Malop.HeaderText = "Lớp";
            this.Malop.MinimumWidth = 6;
            this.Malop.Name = "Malop";
            // 
            // NamNhapHoc
            // 
            this.NamNhapHoc.DataPropertyName = "NamNhapHoc";
            this.NamNhapHoc.HeaderText = "Năm Nhập Học";
            this.NamNhapHoc.MinimumWidth = 6;
            this.NamNhapHoc.Name = "NamNhapHoc";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(51, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "MSV :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(41, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "HỌ TÊN :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(51, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "LỚP :";
            // 
            // txtMSV
            // 
            this.txtMSV.BackColor = System.Drawing.Color.Transparent;
            this.txtMSV.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMSV.BorderRadius = 10;
            this.txtMSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSV.DefaultText = "";
            this.txtMSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMSV.Location = new System.Drawing.Point(105, 57);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.PasswordChar = '\0';
            this.txtMSV.PlaceholderText = "";
            this.txtMSV.ReadOnly = true;
            this.txtMSV.SelectedText = "";
            this.txtMSV.Size = new System.Drawing.Size(76, 20);
            this.txtMSV.TabIndex = 9;
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.Color.Transparent;
            this.txtHoten.BorderColor = System.Drawing.Color.DarkGray;
            this.txtHoten.BorderRadius = 10;
            this.txtHoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoten.DefaultText = "";
            this.txtHoten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoten.Location = new System.Drawing.Point(105, 92);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.PasswordChar = '\0';
            this.txtHoten.PlaceholderText = "";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.SelectedText = "";
            this.txtHoten.Size = new System.Drawing.Size(200, 20);
            this.txtHoten.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.White;
            this.button1.BorderRadius = 10;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.LightCyan;
            this.button1.Location = new System.Drawing.Point(88, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "NHẬP ĐIỂM";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLop
            // 
            this.txtLop.BackColor = System.Drawing.Color.Transparent;
            this.txtLop.BorderColor = System.Drawing.Color.DarkGray;
            this.txtLop.BorderRadius = 10;
            this.txtLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLop.DefaultText = "";
            this.txtLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLop.Location = new System.Drawing.Point(105, 126);
            this.txtLop.Name = "txtLop";
            this.txtLop.PasswordChar = '\0';
            this.txtLop.PlaceholderText = "";
            this.txtLop.ReadOnly = true;
            this.txtLop.SelectedText = "";
            this.txtLop.Size = new System.Drawing.Size(76, 20);
            this.txtLop.TabIndex = 13;
            // 
            // radioButtonHK1
            // 
            this.radioButtonHK1.AutoSize = true;
            this.radioButtonHK1.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonHK1.CheckedState.BorderThickness = 0;
            this.radioButtonHK1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonHK1.Location = new System.Drawing.Point(57, 222);
            this.radioButtonHK1.Name = "radioButtonHK1";
            this.radioButtonHK1.Size = new System.Drawing.Size(68, 19);
            this.radioButtonHK1.TabIndex = 14;
            this.radioButtonHK1.TabStop = true;
            this.radioButtonHK1.Text = "Học Kỳ I";
            this.radioButtonHK1.UncheckedState.BorderThickness = 0;
            this.radioButtonHK1.UseVisualStyleBackColor = false;
            // 
            // radioButtonHK2
            // 
            this.radioButtonHK2.AutoSize = true;
            this.radioButtonHK2.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonHK2.CheckedState.BorderThickness = 0;
            this.radioButtonHK2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonHK2.Location = new System.Drawing.Point(184, 222);
            this.radioButtonHK2.Name = "radioButtonHK2";
            this.radioButtonHK2.Size = new System.Drawing.Size(71, 19);
            this.radioButtonHK2.TabIndex = 15;
            this.radioButtonHK2.TabStop = true;
            this.radioButtonHK2.Text = "Học Kỳ II";
            this.radioButtonHK2.UncheckedState.BorderThickness = 0;
            this.radioButtonHK2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(40, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "TỔNG ĐIỂM RL :";
            // 
            // txtTongDiemRL
            // 
            this.txtTongDiemRL.BackColor = System.Drawing.Color.Transparent;
            this.txtTongDiemRL.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTongDiemRL.BorderRadius = 10;
            this.txtTongDiemRL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongDiemRL.DefaultText = "";
            this.txtTongDiemRL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongDiemRL.Location = new System.Drawing.Point(137, 261);
            this.txtTongDiemRL.Name = "txtTongDiemRL";
            this.txtTongDiemRL.PasswordChar = '\0';
            this.txtTongDiemRL.PlaceholderText = "";
            this.txtTongDiemRL.SelectedText = "";
            this.txtTongDiemRL.Size = new System.Drawing.Size(118, 20);
            this.txtTongDiemRL.TabIndex = 17;
            this.txtTongDiemRL.TextChanged += new System.EventHandler(this.txtTongDiemRL_TextChanged);
            // 
            // cbboxNamHoc
            // 
            this.cbboxNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbboxNamHoc.BorderRadius = 10;
            this.cbboxNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxNamHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cbboxNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbboxNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbboxNamHoc.FormattingEnabled = true;
            this.cbboxNamHoc.ItemHeight = 30;
            this.cbboxNamHoc.Location = new System.Drawing.Point(105, 168);
            this.cbboxNamHoc.Name = "cbboxNamHoc";
            this.cbboxNamHoc.Size = new System.Drawing.Size(134, 36);
            this.cbboxNamHoc.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(32, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "NĂM HỌC :";
            // 
            // groupBox1
            // 
            this.groupBox1.BorderRadius = 10;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbboxNamHoc);
            this.groupBox1.Controls.Add(this.txtTongDiemRL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioButtonHK2);
            this.groupBox1.Controls.Add(this.radioButtonHK1);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMSV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(23, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 383);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Điểm :";
            // 
            // groupBox2
            // 
            this.groupBox2.BorderRadius = 10;
            this.groupBox2.Controls.Add(this.btnLoadSV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbboxchonlop);
            this.groupBox2.Controls.Add(this.cbboxChonkhoa);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox2.Location = new System.Drawing.Point(23, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 157);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc Sinh Viên";
            // 
            // btnLoadSV
            // 
            this.btnLoadSV.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadSV.BorderRadius = 10;
            this.btnLoadSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadSV.ForeColor = System.Drawing.Color.White;
            this.btnLoadSV.Image = global::QLSV_DH.Properties.Resources.icons8_refresh_40;
            this.btnLoadSV.Location = new System.Drawing.Point(222, 70);
            this.btnLoadSV.Name = "btnLoadSV";
            this.btnLoadSV.Size = new System.Drawing.Size(131, 51);
            this.btnLoadSV.TabIndex = 4;
            this.btnLoadSV.Text = "    CẬP NHẬT";
            this.btnLoadSV.Click += new System.EventHandler(this.btnLoadSV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderRadius = 10;
            this.pictureBox1.Image = global::QLSV_DH.Properties.Resources._202004091154448852_54972fefc1ce01cc5f2e642e616eaa501;
            this.pictureBox1.ImageRotate = 0F;
            this.pictureBox1.Location = new System.Drawing.Point(23, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmNhapDiemRL
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1380, 850);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhapDiemRL";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Nhập Điểm Rèn Luyện";
            this.Load += new System.EventHandler(this.FrmNhapDiemRL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbboxChonkhoa;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxchonlop;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel label2;
        private Guna.UI2.WinForms.Guna2Button btnLoadSV;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel  label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMSV;
        private Guna.UI2.WinForms.Guna2TextBox txtHoten;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2TextBox txtLop;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonHK1;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonHK2;
        private Guna.UI2.WinForms.Guna2HtmlLabel label6;
        private Guna.UI2.WinForms.Guna2TextBox txtTongDiemRL;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxNamHoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel label7;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamNhapHoc;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}