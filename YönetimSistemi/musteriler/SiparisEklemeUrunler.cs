using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönetimSistemi.musteriler
{
    public partial class SiparisEklemeUrunler : Form
    {
        public SiparisEklemeUrunler()
        {
            InitializeComponent();
        }

        private void buttongeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
