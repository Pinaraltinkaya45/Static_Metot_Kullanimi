using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Metot_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan C1 = new Calisan();

            C1.calisanID = 1;
            C1.isim = "Pınar";
            C1.soyisim = "ALTINKAYA";
            Calisan.maas = 200000; // static olduğu zaman class ismi üzerinden erişim sağladım


            Console.WriteLine("Çalisan id : "+ C1.calisanID);
            Console.WriteLine("Calisan isim : "+ C1.isim);
            Console.WriteLine("Calisan soyisim "+C1.soyisim);
            Console.WriteLine("Calisan maas : "+ Calisan.maas);

            Console.ReadLine();




        }
    }
}
