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
    public partial class UyeForm : Form
    {
        public UyeForm()
        {
            InitializeComponent();
            if (RandevuList.randevuListe == null)
                RandevuList.randevuListe = new List<Randevu>();
        }

        private void butonRandevuAl_Click(object sender, EventArgs e)
        {
            RandevuForm randevuForm = new RandevuForm();
            randevuForm.Show();
            this.Hide();
        }

        private void butonRandevuGor_Click(object sender, EventArgs e)
        {
            RandevuGoruntuleForm randevuGor = new RandevuGoruntuleForm();
            randevuGor.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void UyeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
