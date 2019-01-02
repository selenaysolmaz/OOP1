using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class TarihBİlgisi
    {
        private DateTime tarih;
        public string GecerliTarih
        {
            set { tarih = Convert.ToDateTime(value); }
        }
        private double GunOlarakTarihFarki(DateTime farkAlinacakTarih)
        {
            return (farkAlinacakTarih - tarih).TotalDays;
        }
        public string GunFarki(string YeniTarih)
        {
            return GunOlarakTarihFarki(Convert.ToDateTime(YeniTarih)).ToString() + "gun fark var";
        }

    }
}
