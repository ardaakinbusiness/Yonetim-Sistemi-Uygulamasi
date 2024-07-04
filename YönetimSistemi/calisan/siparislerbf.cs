using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YönetimSistemi.calisan
{
    public partial class siparislerbf : Form
    {
        public siparislerbf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SiparisE SiparisE = new SiparisE();
            SiparisE.ShowDialog();
        }

        private void siparislerbf_Load(object sender, EventArgs e)
        {

        }
    }
}
