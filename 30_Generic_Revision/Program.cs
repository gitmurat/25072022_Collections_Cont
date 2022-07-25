using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Generic_Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("List");
            list.Add("Array");
            list.Add("Hastable");
            list.Add("Dictionary");
            list.Add("ArrayList");

            list.Sort();

            foreach (var item in list)
                Console.WriteLine(item);

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(6, "Ankara");
            dict.Add(34, "İstanbul");
            dict.Add(10, "Balıkesir");

            dict[60]= "Tokat";

            foreach (var key in dict.Keys)
            {
                Console.WriteLine(key + " = " + dict[key]);
            }
        }
    }
}
