using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Sistemi.NewFolder1
{
    public class Randevu
    {
        public Kullanici kullanici;
        public Doktor doktor;
        public string rahatsizlik;
        public DateTime randevuTarihi;
    }
    public static class RandevuList
    {
        public static List<Randevu> randevuListe;
    }
}
