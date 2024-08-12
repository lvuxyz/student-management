namespace QLSV_DH
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txt_peopleSned = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_mess = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.img_client = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_client)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(306, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // txt_peopleSned
            // 
            this.txt_peopleSned.BackColor = System.Drawing.Color.Transparent;
            this.txt_peopleSned.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_peopleSned.Location = new System.Drawing.Point(73, 5);
            this.txt_peopleSned.Name = "txt_peopleSned";
            this.txt_peopleSned.Size = new System.Drawing.Size(85, 27);
            this.txt_peopleSned.TabIndex = 1;
            this.txt_peopleSned.Text = "Giáo Viên";
            // 
            // txt_mess
            // 
            this.txt_mess.BackColor = System.Drawing.Color.White;
            this.txt_mess.BorderColor = System.Drawing.Color.White;
            this.txt_mess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mess.DefaultText = "Lớp CNTT 12.10.2 chiều mai đi học đầy đủ để kiểm tra\r\n";
            this.txt_mess.DisabledState.BorderColor = System.Drawing.Color.White;
            this.txt_mess.DisabledState.FillColor = System.Drawing.Color.White;
            this.txt_mess.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txt_mess.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_mess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mess.ForeColor = System.Drawing.Color.Gray;
            this.txt_mess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mess.Location = new System.Drawing.Point(64, 24);
            this.txt_mess.Multiline = true;
            this.txt_mess.Name = "txt_mess";
            this.txt_mess.PasswordChar = '\0';
            this.txt_mess.PlaceholderForeColor = System.Drawing.Color.White;
            this.txt_mess.PlaceholderText = "";
            this.txt_mess.ReadOnly = true;
            this.txt_mess.SelectedText = "";
            this.txt_mess.Size = new System.Drawing.Size(244, 55);
            this.txt_mess.TabIndex = 4;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // img_client
            // 
            this.img_client.Image = ((System.Drawing.Image)(resources.GetObject("img_client.Image")));
            this.img_client.ImageRotate = 0F;
            this.img_client.Location = new System.Drawing.Point(12, 12);
            this.img_client.Name = "img_client";
            this.img_client.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.img_client.Size = new System.Drawing.Size(55, 55);
            this.img_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_client.TabIndex = 2;
            this.img_client.TabStop = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 80);
            this.Controls.Add(this.txt_peopleSned);
            this.Controls.Add(this.img_client);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.txt_mess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Message";
            ((System.ComponentModel.ISupportInitialize)(this.img_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txt_peopleSned;
        private Guna.UI2.WinForms.Guna2CirclePictureBox img_client;
        private Guna.UI2.WinForms.Guna2TextBox txt_mess;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}