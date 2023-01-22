using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkol__7
{
    internal class Produkt : Zbozi
    {
        private bool lzeZlevnit;
        public Produkt(string nazev, int cena, DateTime datumVyroby, int minimalniTrvanlivost, bool lzeZlevnit) : base(nazev, cena, datumVyroby, minimalniTrvanlivost)
        {
            this.lzeZlevnit = lzeZlevnit;
        }
        public override int CenasDPH()
        {
            double cenaDPH = cena * 1.21;
            if(lzeZlevnit == true & Trvanlivost())
            {
                return Convert.ToInt32(cenaDPH);
            }
            else
            {
                return Convert.ToInt32(base.CenasDPH() * 0.6);
            }
            
        }
    }
}
