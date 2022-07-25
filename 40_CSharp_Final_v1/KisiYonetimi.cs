using Sistem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_CSharp_Final
{
    internal class KisiYonetimi
    {
        public static Kisi GetKisi()
        {
            string adi = Ekran.ReadString("Adı:");
            string soyadi = Ekran.ReadString("Soyadi");
            int dogumYili = Ekran.ReadInt("Doğum Yılı");

            Kisi kisi = new Kisi(adi, soyadi);
            kisi.DogumYili = dogumYili;

            return kisi;
        }

        public static void KisiList (List<Kisi> kisilistesi)
        {
            int count = 0;
            foreach (var item in kisilistesi)
            {
                Console.WriteLine(count++ + ". Kişi:  " + item);
            }
            Ekran.DrawLine();
            Console.WriteLine("Listede " + kisilistesi.Count + " kisi var");
        }
    }
}
