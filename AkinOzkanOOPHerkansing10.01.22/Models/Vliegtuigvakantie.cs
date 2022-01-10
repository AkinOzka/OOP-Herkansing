using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinOzkanOOPHerkansing10._01._22.Models
{
    public class Vliegtuigvakantie:Reis
    {
        public Vliegtuigvakantie(DateTime terugDatum, DateTime vertrekDatum, int aantalPersonen, int vliegtuigTicketPrijs) : base(terugDatum, vertrekDatum, aantalPersonen)
        {
            VliegtuigTicketPrijs = vliegtuigTicketPrijs;
        }
        public double VliegtuigTicketPrijs { get; private set; }
        public override double BerekenPrijs()
        {
            return base.BerekenPrijs() + VliegtuigTicketPrijs;
        }
    }
}
