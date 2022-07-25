using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Object_Var_Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            object objSayi = sayi;

            Console.WriteLine(objSayi + " değeri");

            int yeniSayi = (int)objSayi;

            Console.WriteLine(yeniSayi + 1);

            var no = 1;
            var adi = "İlker";
            var lamp = true;
        }
    }
}
