using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yonetim_Sistemi_DAL;
using YönetimSistemi.Yonetim;

namespace YönetimSistemi.calisan
{
    public partial class MusteriE : Form
    {
        public MusteriE()
        {
            InitializeComponent();
        }

        private void buttonurunekle_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new deneme34Entities2();
                context.Musteriler.Add(new Yonetim_Sistemi_DAL.Musteriler()
                {
                    MusteriID = int.Parse(CalisanMusteriEkleID.Text),
                    Ad = textBoxad.Text,
                    Soyad = textBoxsoyad.Text,
                    Email = textBoxemail.Text,
                    Telefon = textBoxtel.Text,
                   
                    
                });
                context.SaveChanges();
                MessageBox.Show("Müşteri Ekleme Başarılıdır.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch { }
        }

        private void buttongeri_Click(object sender, EventArgs e)
        {
            Musterilerbf musterilerbf = new Musterilerbf();
            musterilerbf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MusteriE_Load(object sender, EventArgs e)
        {
           
        }
    }
}
