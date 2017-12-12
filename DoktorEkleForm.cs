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
    public partial class DoktorEkleForm : Form
    {
        public DoktorEkleForm()
        {
            InitializeComponent();
            if (DoktorList.doktorListe == null)//Herhangi bir işlem yapmadan önce DoctorListin içerisi boş mu diye kontrol ediyoruz.
                DoktorList.doktorListe = new List<Doktor>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor()
            {
                adSoyad=textad.Text
                
            };
            DoktorList.doktorListe.Add(doktor);
            MessageBox.Show (textad.Text+"'ı eklediniz.");

        }

        private void butoncikis_Click(object sender, EventArgs e)
        {
            AdminForm adminform = new AdminForm();
            adminform.Show();
            this.Hide();
        }
    }
}
