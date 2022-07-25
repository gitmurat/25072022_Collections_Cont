using Sistem;

namespace _40_CSharp_Final

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> Kisiler = new List<Kisi>();

            Ekran.WriteHeader("Kişiler");

            bool yeniKisi = false;

            do
            {
                Kisi kisi = KisiYonetimi.GetKisi();
                Kisiler.Add(kisi);
                yeniKisi = Ekran.ReadBool("Bir kişi daha eklemek ister misiniz?");
            } while (yeniKisi);

            Ekran.DrawLine();

            KisiYonetimi.KisiList(Kisiler);



            /*İlk alıştırmalar
             * Ekran.WriteHeader("Kişi Oku");
            Kisi kisi1 = KisiYonetimi.GetKisi();
            Console.WriteLine();
            Console.WriteLine("2. Kişi --------------");
            Kisi kisi2 = KisiYonetimi.GetKisi();

            Console.WriteLine(kisi1);
            Console.WriteLine(kisi2);*/
        }
    }
}