using System;
using System.Windows.Forms;

namespace QLSV_DH
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());
            Application.Run(new FrmMain());
            //Application.Run(new Message("Giao vien", "Lớp CNTT 12.10.2 chiều mai đi học đầy đủ để kiểm tra giữa kỳ"));

        }
    }
}
