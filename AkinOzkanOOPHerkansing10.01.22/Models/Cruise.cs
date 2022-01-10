using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinOzkanOOPHerkansing10._01._22.Models
{
    public class Cruise : Reis
    {
        public Cruise(DateTime terugDatum, DateTime vertrekDatum, int aantalPersonen, bool vip) : base(terugDatum, vertrekDatum, aantalPersonen)
        {
            VIP = vip;
        }
        public const double CRUISEPRIJSEXTRADAGKOST = 10;
        public bool VIP { get; private set; }
        public override double BerekenPrijs()
        {
            double basisprijs = base.BerekenPrijs() + (CRUISEPRIJSEXTRADAGKOST * AantalPersonen);

            if (!VIP)
            {
                return basisprijs;
            }
            else
            {
                return basisprijs * 1.5;
            }
        }
    }
}
