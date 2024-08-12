using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_DH
{
    public partial class Message : Form
    {
        private string senderName;
        private string message;
        public Message(int Index, string senderName, string message, int sobuoi = 0)
        {
            InitializeComponent();
            this.senderName = senderName;
            this.message = message;

            txt_peopleSned.Text = senderName;
            txt_mess.Text = message;
            int Y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Y - (Index * 90));

            if (sobuoi == 1) { img_client.Image = Properties.Resources.Brake_Warning; }
            if (sobuoi == 3)
            {
                img_client.Image = Properties.Resources.High_Priority; this.StartPosition = FormStartPosition.CenterScreen; this.TopMost = true;
            }

        }
    }
}
