using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Sistemi.NewFolder1
{
    public class Kullanici
    {
        public string ad;
        public string soyad;
        public string kullaniciAdi;
        public string sifre;
        public bool isAdmin;
    }
    public static class kullaniciList
    {
        public static List<Kullanici> kullaniciListe;
        public static Kullanici aktifKullanici;
    }
}
