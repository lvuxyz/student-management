using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace QLSV_DH
{
    public partial class FrmLogin : Form
    {
        public SendMessage send;
        public FrmLogin()
        {
            InitializeComponent();
        }
        public FrmLogin(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.MaxLength = 15;
            txtPassword.MaxLength = 15;
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if (txtUsername.TextLength == 0 && txtPassword.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập User và Password");
                this.txtUsername.Focus();
            }
            else if (txtUsername.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập User");
                this.txtUsername.Focus();
            }
            else if (txtPassword.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập Password");
                this.txtPassword.Focus();
            }
            else
            {
                Admin a = new Admin();
               
                if (a.checklog(txtUsername.Text, GetMD5(txtPassword.Text)) == true)
                {
                    String str = a.Quyenhan(txtUsername.Text, GetMD5(txtPassword.Text));
                    this.send(txtUsername.Text, str);
                    this.Close();
                }
                else if (a.checktentk(txtUsername.Text) == true)
                {
                    MessageBox.Show("Sai password");
                }
                else if (a.checkpass(GetMD5(txtPassword.Text)) == true)
                {
                    MessageBox.Show("Sai Username");
                }
                else
                {
                    MessageBox.Show("Tài Khoản Không Tồn Tại !!");
                }
            }
        }
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui Lòng Liên Hệ Cố Vấn Của Bạn Để Được Cung Cấp Tài Khoản !");
        }

        private VideoCapture _capture;
        private bool _captureInProgress;
        private void btn_FaceIDCheck_Click(object sender, EventArgs e)
        {
            try
            {
                //_capture = new VideoCapture(1); // Sử dụng camera mặc định (0) hoặc chọn camera cụ thể
                _capture = new VideoCapture("0");

                if (_capture != null)
                {
                    _capture.ImageGrabbed += ProcessFrame;
                    _capture.Start();
                    _captureInProgress = true;
                }
                else
                {
                    MessageBox.Show("Không thể truy cập camera.");
                }
            }
            catch
            {
                MessageBox.Show("Không thể truy cập camera.");
            }
           
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            try
            {
                Mat frame = new Mat();
                _capture.Retrieve(frame);

                if (frame != null)
                {
                    P_FaceID.Image = frame.ToImage<Bgr, byte>().ToBitmap();
                }
            }
            catch
            {

            }
        }
        private void P_FaceID_DoubleClick(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.ImageGrabbed -= ProcessFrame;
                _capture.Stop();
                _capture.Dispose();
            }
        }
    }
}
