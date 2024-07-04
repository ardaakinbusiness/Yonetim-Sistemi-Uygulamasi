using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönetimSistemi.Yonetim
{
    public partial class KullaniciAdd : Form
    {
        public KullaniciAdd()
        {
            InitializeComponent();
        }

        private void YonetimKullaniciGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
