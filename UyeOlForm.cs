using Randevu_Sistemi.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu_Sistemi
{
    public partial class UyeOlForm : Form
    {
        
        public UyeOlForm()
        {
           
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            ValidationManager validationManager = new ValidationManager();
            bool validName = validationManager.ValidateField(textAd.Text);
            bool validLastname = validationManager.ValidateField(textSoyad.Text);
            bool validUsername = validationManager.ValidateField(textKullaniciAd.Text);
            bool validPassword = validationManager.ValidateField(textSifre.Text);
            string validationSummary = "";
            if (!validName && !validLastname && !validUsername && !validPassword)
            {
                validationSummary += "Boş bırakmayınız";
                labelValidation.Text = validationSummary;
                labelValidation.Visible = true;
                return;
            }
            else
            {
                labelValidation.Text = "";
                labelValidation.Visible = false;
            }
            Kullanici kullanici = new Kullanici();
           
            kullanici.ad = textAd.Text;
            kullanici.soyad = textSoyad.Text;
            kullanici.kullaniciAdi = textKullaniciAd.Text;
            kullanici.sifre = textSifre.Text;

            kullaniciList.kullaniciListe.Add(kullanici);
        }
        private void butonGiris_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
