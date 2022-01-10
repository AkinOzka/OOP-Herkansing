using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinOzkanOOPHerkansing10._01._22.Models
{
    public class AutoVakantie : Reis
    {
        public AutoVakantie(DateTime terugDatum, DateTime vertrekDatum, int aantalPersonen,bool eigenwagen) : base(terugDatum, vertrekDatum, aantalPersonen)
        {
            Eigenwagen = eigenwagen;
        }
        public bool Eigenwagen { get; private set; }
        private const double EXTRAPRIJSHUURAUTO = 10;
        private const double RESERVATIEKOST = 30;
        public override double BerekenPrijs()
        {
            if (Eigenwagen)
            {
                return RESERVATIEKOST;
            }

            else if (AantalPersonen > 5)
            {
                throw new Exception("You must rent another car.");
            }
            else
            {
                return base.BerekenPrijs() + (AantalDagen * EXTRAPRIJSHUURAUTO);
            }
        }
    }
}
