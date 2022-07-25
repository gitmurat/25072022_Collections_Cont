using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_CSharp_Final
{
    internal class Kisi
    {
        #region Properties
        private readonly string _Adi;

        public string Adi
        {
            get { return _Adi; }
        }

        private readonly string _Soyadi;

        public string Soyadi
        {
            get { return _Soyadi; }
        }

        public string TamAdi
        {
            get
            { return Adi + " " + Soyadi.ToUpper(); }
        }


        public int DogumYili { get; set; }
        public int Yas
        {
            get
            { return DateTime.Now.Year - DogumYili; }
        }


        public override string ToString()
        {
            return TamAdi + "(" + Yas + ")";
        }
        #endregion
        
        public Kisi(string adi, string soyadi)
        {
            _Adi = adi;
            _Soyadi = soyadi;
        }
    }
}
