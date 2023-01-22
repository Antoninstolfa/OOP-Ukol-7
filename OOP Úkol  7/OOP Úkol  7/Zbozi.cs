using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkol__7
{
    internal class Zbozi
    {
        protected string nazev;
        protected int cena;
        protected DateTime datumVyroby;
        protected int minimalniTrvanlivost;
        public Zbozi(string nazev, int cena, DateTime datumVyroby, int minimalniTrvanlivost)
        {
            this.nazev = nazev; 
            this.cena = cena;   
            this.datumVyroby = datumVyroby;
            this.minimalniTrvanlivost = minimalniTrvanlivost;
        }

        public bool Trvanlivost()
        {
            TimeSpan trvanlivost = DateTime.Today - datumVyroby;
            if(trvanlivost.TotalDays > minimalniTrvanlivost)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public virtual int CenasDPH()
        {
            double cenaDPH = cena * 1.21;
            return Convert.ToInt32(cenaDPH);
        }
        public override string ToString()
        {
            if(this.Trvanlivost() == true)
            {
                return "Název zboží: " + this.nazev + "\nCena bez DPH: " + Convert.ToString(this.cena) + "    Cena s DPH: " + Convert.ToString(CenasDPH()) + "\nDatum výroby: " + Convert.ToString(this.datumVyroby) + "\nMinimální trvanlivost: " + Convert.ToString(this.minimalniTrvanlivost) + "dní --- zboží je čestvé.";
            }
            else
            {
                return "Název zboží: " + this.nazev + "\nCena bez DPH: " + Convert.ToString(this.cena) + "    Cena s DPH: " + Convert.ToString(CenasDPH()) + "\nDatum výroby: " + Convert.ToString(this.datumVyroby) + "\nMinimální trvanlivost: " + Convert.ToString(this.minimalniTrvanlivost) + "dní --- zboží je prošlé.";
            }
            
        }
    }
}
