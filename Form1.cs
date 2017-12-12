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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (kullaniciList.kullaniciListe == null)
                kullaniciList.kullaniciListe = new List<Kullanici>();
            if (kullaniciList.kullaniciListe.Count < 1)
            {
                Kullanici adminUser = new Kullanici { kullaniciAdi = "admin", sifre = "1234", isAdmin = true };
                kullaniciList.kullaniciListe.Add(adminUser);
            }

        }
        
        private void butonGiriş_Click(object sender, EventArgs e)
        {
            ValidationManager validationManager = new ValidationManager();
            bool validName = validationManager.ValidateField(textKulAdi.Text);
            bool validPassword = validationManager.ValidateField(textSifre.Text);
            string validationSummary = "";
            if (!validName || !validPassword)
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
            bool giris = false;
            foreach (var item in kullaniciList.kullaniciListe)
            {
                if (item.kullaniciAdi == textKulAdi.Text && item.sifre == textSifre.Text)
                {
                    kullaniciList.aktifKullanici = item;
                    giris = true;
                    break;
                }

            }
            if (giris)
            {
                if (kullaniciList.aktifKullanici.isAdmin)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    
                }
                else
                {
                    UyeForm uyeForm = new UyeForm();
                    uyeForm.Show();
                   
                }
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Giriş yaptınız.");
            }

        }

        private void butonUyeOl_Click(object sender, EventArgs e)
        {
            UyeOlForm uyeOlForm = new UyeOlForm();
            uyeOlForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
