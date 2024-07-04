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
using YönetimSistemi.Kullanicilar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YönetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatbtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_girisyap_Click(object sender, EventArgs e)
        {
            
            try
            {
                var context = new deneme34Entities2();
                var Kullanici = context.Kullanici.FirstOrDefault(k =>
                k.KullaniciAdi == textBox_kullaniciadi.Text.ToLower() && k.Sifre == textBox_Sifre.Text && k.Rol == comboBox_rol.SelectedIndex);

                if (Kullanici != null)
                {
                    Program.KullaniciAdi = Kullanici.KullaniciAdi;
                    Program.KullaniciRolu = (int)Kullanici.Rol;
                    Hide();
                    Anasayfa anaSayfa = new Anasayfa();
                    anaSayfa.ShowDialog(); 
                    Show(); 

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch { }
        }

        private void button_girisyap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_girisyap.PerformClick();
            }
        }
    }
}
