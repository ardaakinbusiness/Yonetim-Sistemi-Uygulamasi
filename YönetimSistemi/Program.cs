using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YönetimSistemi.Yonetim;

namespace YönetimSistemi
{
    internal static class Program
    {
        public static int KullaniciRolu { get; set; } = -1;

        public static string KullaniciAdi { get; set; }

        public static string Sifre { get; set; }
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
