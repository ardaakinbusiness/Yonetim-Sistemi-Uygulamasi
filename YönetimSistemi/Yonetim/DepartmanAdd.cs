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
    public partial class DepartmanAdd : Form
    {
        public DepartmanAdd()
        {
            InitializeComponent();
        }

        private void YonetimDepartmanGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
