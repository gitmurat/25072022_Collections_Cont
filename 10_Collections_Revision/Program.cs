using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections_Revision
{
    class Kisi
    {
        public string Adi { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            int[] sayilar = new int[5];
            sayilar[0] = 1;
            Kisi k = new Kisi() { Adi = "Yaşar" };


            ArrayList nesneler = new ArrayList();

            nesneler.Add(12);
            nesneler.Add("Eren");
            nesneler.Add(true);
            nesneler.Add(k);
            nesneler.Add(new Kisi { Adi = "Mert" });

            foreach (object item in nesneler)
            {
                if (item is Kisi)
                {
                    Kisi kisi1 = (Kisi)item;
                    Console.WriteLine("----------------> " + kisi1.Adi);
                }
                else
                Console.WriteLine(item);
            }

        }
    }
}
