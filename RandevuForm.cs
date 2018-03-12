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
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
            if (RandevuList.randevuListe == null)
                RandevuList.randevuListe = new List<Randevu>();
            if (DoktorList.doktorListe == null)
                DoktorList.doktorListe = new List<Doktor>();

            if (DoktorList.doktorListe.Count < 1)
            {
                Doktor doctorName = new Doktor { adSoyad="Ali veli" };
                DoktorList.doktorListe.Add(doctorName);
            }

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Doktor Adı-Soyadı:", 100);
            
            DoktorListEkle();
        }
        public void DoktorListEkle()
        {
            foreach (var item in DoktorList.doktorListe)
            {
                string[] s = { item.adSoyad };
                listView1.Items.Add(new ListViewItem(s));
            }
        }

        private void butonKaydet_Click(object sender, EventArgs e)
        {
            ValidationManager validationManager = new ValidationManager();
            bool valid = validationManager.ValidateField(textBox1.Text);            
            string validationSummary = "";
            if (!valid)
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
            Randevu randevu = new Randevu()
            {
                kullanici = kullaniciList.aktifKullanici,
                rahatsizlik = textBox1.Text,
                randevuTarihi = dateTimePicker1.Value
            };
            if (listView1.SelectedItems.Count > 0)
            {
                randevu.doktor = new Doktor();
                randevu.doktor.adSoyad=listView1.SelectedItems[0].SubItems[0].Text;                
            }
            
            RandevuList.randevuListe.Add(randevu);            
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            label5.Text = kullaniciList.aktifKullanici.ad +" "+ kullaniciList.aktifKullanici.soyad;
        }
        private void butonCikis_Click(object sender, EventArgs e)
        {
            UyeForm uyeform = new UyeForm();
            uyeform.Show();
            this.Hide();
        }
    }
}
