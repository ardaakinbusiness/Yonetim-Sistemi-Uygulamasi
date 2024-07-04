using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yonetim_Sistemi_DAL;

namespace YönetimSistemi.calisan
{
    public partial class SiparisE : Form
    {
        public SiparisE()
        {
            InitializeComponent();
        }

        private void buttonurunekle_Click(object sender, EventArgs e)
        {
            
            try
            {
                var context = new deneme34Entities2();
                context.Siparisler.Add(new Siparisler()
                {
                    UrunID = ((Class1)comboBoxUrun.SelectedItem).Value,
                    Miktar = int.Parse(textBoxMiktar.Text),
                    Tarih = DateTime.Parse(dateTimePicker_sip.Text),
                    TedarikciID = ((Class1)comboBoxTedarikci.SelectedItem).Value,
                    MusteriID = ((Class1)comboBoxMusteriID.SelectedItem).Value,
                });
                context.SaveChanges();
                MessageBox.Show("Sipariş Ekleme Başarılıdır.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch { }
        }

        private void SiparisEklebf_Load(object sender, EventArgs e)
        {
            try
            {

                var context = new deneme34Entities2();

                comboBoxMusteriID.DataSource = context.Musteriler.ToList().Select(k => new Class1()
                {
                    Text = k.Ad,
                    Value = k.MusteriID,
                }).ToList();
                comboBoxUrun.DataSource = context.Urunler.ToList().Select(k => new Class1()
                {
                    Text = k.Ad,
                    Value = k.UrunID,
                }).ToList();
                comboBoxTedarikci.DataSource = context.Tedarikci.ToList().Select(k => new Class1()
                {
                    Text = k.Ad,
                    Value = k.TedarikciID,
                }).ToList();
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttongeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
