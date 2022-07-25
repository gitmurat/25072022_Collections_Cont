namespace Sistem
{
    public class Ekran
    {
        public static void DrawLine()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public static void WriteHeader (string baslik)
        {
            DrawLine();
            Console.WriteLine("    " + baslik.ToUpper());
            DrawLine();
        }

        public static void WriteSmallHeader (string baslik)
        {
            Console.WriteLine();
            Console.WriteLine("   " + baslik.ToUpper());
            DrawLine();
        }

        public static string ReadString(string etiket)
        {
            Console.WriteLine(etiket + " : ");
            return Console.ReadLine();
        }

        public static int ReadInt(string etiket)
        {
            return Convert.ToInt32(ReadString(etiket));
        }

        public static bool ReadBool(string soru)
        {
            Console.Write(soru + "(Evet/Hayır)");
            string harf = Console.ReadLine();

            if (harf.ToUpper() == "E" || harf =="")
                return true;
            else
                return false;
        }
    }
}