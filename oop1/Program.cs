using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            TarihBİlgisi t = new TarihBİlgisi();
            t.GecerliTarih = "30.12.2018";
            Console.WriteLine(t.GunFarki(DateTime.Today.ToString()));
            Console.ReadKey();
        }
    }
}
