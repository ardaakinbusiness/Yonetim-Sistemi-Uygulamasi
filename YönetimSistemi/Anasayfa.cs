using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yonetim_Sistemi_DAL;
using YönetimSistemi.calisan;
using YönetimSistemi.Kullanicilar;
using YönetimSistemi.musteriler;
using YönetimSistemi.Musteriler;
using YönetimSistemi.Yonetim;

namespace YönetimSistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void kptbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 1)
            {
                yonetimcs yonetimcs = new yonetimcs();
                yonetimcs.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 0)
            {
                Musterilerbf musterilerbf = new Musterilerbf();
                musterilerbf.ShowDialog();
            }
            else if (Program.KullaniciRolu == 1)
            {
                Customercs musterilercs = new Customercs();
                musterilercs.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 1)
            {
                Kullanicics kullanici = new Kullanicics();
                kullanici.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 0)
            {
                siparislerbf siparislerbf = new siparislerbf();
                siparislerbf.ShowDialog();
            }
           else if (Program.KullaniciRolu == 1)
            {
                siparislercs siparislercs = new siparislercs();
                siparislercs.ShowDialog();
            }
            else if (Program.KullaniciRolu == 2)
            {
                siparislervd siparislervd = new siparislervd();
                siparislervd.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 1)
            {
                departmancs departmancs = new departmancs();
                departmancs.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 1)
            {
                pozisyoncs pozisyoncs = new pozisyoncs();
                pozisyoncs.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 0)
            {
                urunlervd urunlervd = new urunlervd();
                urunlervd.ShowDialog();
            }
            else if (Program.KullaniciRolu == 1)
            {
                Urunlercs urunlercs = new Urunlercs();
                urunlercs.ShowDialog();
            }
            else if (Program.KullaniciRolu == 2)
            {
                urunlervd urunlervd = new urunlervd();
                urunlervd.ShowDialog();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 0)
            {
                tedarikcibf tedarikcibf = new tedarikcibf();
                tedarikcibf.ShowDialog();
            }
            else if (Program.KullaniciRolu == 1)
            {
                Tedarikcics tedarikcics = new Tedarikcics();
                tedarikcics.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 1)
            {
                Calisanlarcs Calisanlarcs = new Calisanlarcs();
                Calisanlarcs.ShowDialog();
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            if (Program.KullaniciRolu == 0)
            {
                button1.Hide();
                button4.Hide();
                button6.Hide();
                button7.Hide();
                button2.Hide();
                pictureBox6.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox7.Hide();
            }
            else if (Program.KullaniciRolu == 2)
            {
                button1.Hide();
                button4.Hide();
                button6.Hide();
                button7.Hide();
                button2.Hide();
                pictureBox6.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox7.Hide();
                button3.Hide();
                button5.Hide();
                pictureBox1.Hide();
                pictureBox9.Hide();
            }
        }
    }
}
