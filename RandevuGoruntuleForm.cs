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
    public partial class RandevuGoruntuleForm : Form
    {
        public RandevuGoruntuleForm()
        {
            InitializeComponent();
            if (RandevuList.randevuListe == null)//RandevuListin boş olup olmadığını kontrol ediyoruz.
                RandevuList.randevuListe = new List<Randevu>();
            if (kullaniciList.kullaniciListe == null)//RandevuListin boş olup olmadığını kontrol ediyoruz.
                kullaniciList.kullaniciListe = new List<Kullanici>();
            if (DoktorList.doktorListe == null)//RandevuListin boş olup olmadığını kontrol ediyoruz.
                DoktorList.doktorListe = new List<Doktor>();
            listView1.View = View.Details;
            listView1.Columns.Add("Hasta Adı", 100);
            listView1.Columns.Add("Hasta SoyAdı", 100);            
            listView1.Columns.Add("Randevu Tarihi", 100);
            listView1.Columns.Add("Rahatsızlık Özeti", 100);
            listView1.Columns.Add("Doktor Adı-Soyadı", 100);
            
        }

        private void RandevuGoruntuleForm_Load(object sender, EventArgs e)
        {
            foreach (var item in RandevuList.randevuListe)
            {
                if (!kullaniciList.aktifKullanici.isAdmin)
                {
                    if (item.kullanici.kullaniciAdi != kullaniciList.aktifKullanici.kullaniciAdi)
                        continue;
                    string[] s = { item.kullanici.ad, item.kullanici.soyad, item.randevuTarihi.ToShortDateString(), item.rahatsizlik, item.doktor.adSoyad };
                    listView1.Items.Add(new ListViewItem(s));
                }
            }
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullaniciList.aktifKullanici.isAdmin)
            {
                AdminForm admin = new AdminForm();
                admin.Show();
            }
            else
            {
                UyeForm uye = new UyeForm();
                uye.Show();
            }
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
