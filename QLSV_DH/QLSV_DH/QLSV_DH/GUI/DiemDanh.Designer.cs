namespace QLSV_DH
{
    partial class DiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemDanh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbx_Khoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbx_lop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_EndDiemDanh = new Guna.UI2.WinForms.Guna2Button();
            this.cbx_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_ExportEX = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Load = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_Vang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgv_SV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.chk_DiemDanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer1 = new System.Timers.Timer();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_MonHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Khoa
            // 
            this.cbx_Khoa.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Khoa.BorderRadius = 5;
            this.cbx_Khoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Khoa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_Khoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_Khoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_Khoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_Khoa.ItemHeight = 30;
            this.cbx_Khoa.Location = new System.Drawing.Point(167, 111);
            this.cbx_Khoa.Name = "cbx_Khoa";
            this.cbx_Khoa.Size = new System.Drawing.Size(200, 36);
            this.cbx_Khoa.TabIndex = 1;
            this.cbx_Khoa.SelectedIndexChanged += new System.EventHandler(this.cbx_Khoa_SelectedIndexChanged);
            // 
            // cbx_lop
            // 
            this.cbx_lop.BackColor = System.Drawing.Color.Transparent;
            this.cbx_lop.BorderRadius = 5;
            this.cbx_lop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_lop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_lop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_lop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_lop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_lop.ItemHeight = 30;
            this.cbx_lop.Location = new System.Drawing.Point(457, 54);
            this.cbx_lop.Name = "cbx_lop";
            this.cbx_lop.Size = new System.Drawing.Size(177, 36);
            this.cbx_lop.TabIndex = 2;
            this.cbx_lop.SelectedIndexChanged += new System.EventHandler(this.cbx_lop_SelectedIndexChanged);
            // 
            // btn_EndDiemDanh
            // 
            this.btn_EndDiemDanh.BorderRadius = 5;
            this.btn_EndDiemDanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_EndDiemDanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_EndDiemDanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_EndDiemDanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_EndDiemDanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_EndDiemDanh.ForeColor = System.Drawing.Color.White;
            this.btn_EndDiemDanh.Location = new System.Drawing.Point(661, 111);
            this.btn_EndDiemDanh.Name = "btn_EndDiemDanh";
            this.btn_EndDiemDanh.Size = new System.Drawing.Size(180, 36);
            this.btn_EndDiemDanh.TabIndex = 3;
            this.btn_EndDiemDanh.Text = "Lưu Điểm Danh";
            this.btn_EndDiemDanh.Click += new System.EventHandler(this.btn_EndDiemDanh_Click);
            // 
            // cbx_Date
            // 
            this.cbx_Date.BorderRadius = 5;
            this.cbx_Date.Checked = true;
            this.cbx_Date.FillColor = System.Drawing.Color.CornflowerBlue;
            this.cbx_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbx_Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cbx_Date.Location = new System.Drawing.Point(167, 54);
            this.cbx_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbx_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cbx_Date.Name = "cbx_Date";
            this.cbx_Date.Size = new System.Drawing.Size(200, 36);
            this.cbx_Date.TabIndex = 4;
            this.cbx_Date.Value = new System.DateTime(2023, 9, 27, 14, 11, 0, 28);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.btn_ExportEX);
            this.guna2GroupBox1.Controls.Add(this.cbx_MonHoc);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.btn_Load);
            this.guna2GroupBox1.Controls.Add(this.cbx_lop);
            this.guna2GroupBox1.Controls.Add(this.btn_EndDiemDanh);
            this.guna2GroupBox1.Controls.Add(this.cbx_Date);
            this.guna2GroupBox1.Controls.Add(this.cbx_Khoa);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1380, 166);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Điểm danh";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // btn_ExportEX
            // 
            this.btn_ExportEX.AnimatedGIF = true;
            this.btn_ExportEX.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_ExportEX.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_ExportEX.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExportEX.Image")));
            this.btn_ExportEX.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_ExportEX.ImageRotate = 0F;
            this.btn_ExportEX.Location = new System.Drawing.Point(863, 65);
            this.btn_ExportEX.Name = "btn_ExportEX";
            this.btn_ExportEX.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_ExportEX.Size = new System.Drawing.Size(70, 74);
            this.btn_ExportEX.TabIndex = 15;
            this.btn_ExportEX.Click += new System.EventHandler(this.btn_ExportEX_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày điểm danh";
            // 
            // btn_Load
            // 
            this.btn_Load.BorderRadius = 5;
            this.btn_Load.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Load.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Load.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Load.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Load.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Load.ForeColor = System.Drawing.Color.White;
            this.btn_Load.Location = new System.Drawing.Point(661, 54);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(180, 36);
            this.btn_Load.TabIndex = 9;
            this.btn_Load.Text = "Load";
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.guna2Panel1.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.guna2Panel1.Controls.Add(this.lb_Vang);
            this.guna2Panel1.Controls.Add(this.dgv_SV);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 166);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(50);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(50);
            this.guna2Panel1.Size = new System.Drawing.Size(1380, 670);
            this.guna2Panel1.TabIndex = 6;
            // 
            // lb_Vang
            // 
            this.lb_Vang.BackColor = System.Drawing.Color.Transparent;
            this.lb_Vang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_Vang.Location = new System.Drawing.Point(1201, 27);
            this.lb_Vang.Name = "lb_Vang";
            this.lb_Vang.Size = new System.Drawing.Size(3, 2);
            this.lb_Vang.TabIndex = 16;
            this.lb_Vang.Text = null;
            // 
            // dgv_SV
            // 
            this.dgv_SV.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_SV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_SV.ColumnHeadersHeight = 30;
            this.dgv_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_SV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_DiemDanh});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SV.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_SV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SV.Location = new System.Drawing.Point(50, 50);
            this.dgv_SV.Name = "dgv_SV";
            this.dgv_SV.RowHeadersVisible = false;
            this.dgv_SV.RowHeadersWidth = 50;
            this.dgv_SV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_SV.RowTemplate.Height = 30;
            this.dgv_SV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_SV.Size = new System.Drawing.Size(1280, 570);
            this.dgv_SV.TabIndex = 1;
            this.dgv_SV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_SV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_SV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_SV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_SV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_SV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_SV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_SV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_SV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_SV.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_SV.ThemeStyle.ReadOnly = false;
            this.dgv_SV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_SV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgv_SV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_SV.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_SV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_SV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SV_CellClick);
            // 
            // chk_DiemDanh
            // 
            this.chk_DiemDanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.chk_DiemDanh.FillWeight = 30F;
            this.chk_DiemDanh.HeaderText = "Chk";
            this.chk_DiemDanh.Name = "chk_DiemDanh";
            this.chk_DiemDanh.TrueValue = "";
            this.chk_DiemDanh.Width = 50;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Môn học";
            // 
            // cbx_MonHoc
            // 
            this.cbx_MonHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbx_MonHoc.BorderRadius = 5;
            this.cbx_MonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_MonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MonHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_MonHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_MonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_MonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_MonHoc.ItemHeight = 30;
            this.cbx_MonHoc.Location = new System.Drawing.Point(457, 111);
            this.cbx_MonHoc.Name = "cbx_MonHoc";
            this.cbx_MonHoc.Size = new System.Drawing.Size(177, 36);
            this.cbx_MonHoc.TabIndex = 14;
            this.cbx_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbx_MonHoc_SelectedIndexChanged);
            // 
            // DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 836);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DiemDanh";
            this.Load += new System.EventHandler(this.DiemDanh_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Timers.Timer timer1;

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbx_Khoa;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_lop;
        private Guna.UI2.WinForms.Guna2Button btn_EndDiemDanh;
        private Guna.UI2.WinForms.Guna2DateTimePicker cbx_Date;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_SV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_DiemDanh;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_ExportEX;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_Vang;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_MonHoc;
        private System.Windows.Forms.Label label4;
    }
}