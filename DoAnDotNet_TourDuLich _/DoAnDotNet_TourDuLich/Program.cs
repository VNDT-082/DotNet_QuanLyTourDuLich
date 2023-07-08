using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnDotNet_TourDuLich.Form_Design.Form_QuanTri;
using DoAnDotNet_TourDuLich.Form_Design.FormKhachs;

namespace DoAnDotNet_TourDuLich
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
            Application.Run(new Form1());
        }
    }
}
