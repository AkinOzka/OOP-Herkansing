using AkinOzkanOOPHerkansing10._01._22.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinOzkanOOPHerkansing10._01._22.Models
{
    public abstract class Reis:IBereken
    {
        public Reis(DateTime terugDatum, DateTime vertrekDatum, int aantalPersonen)
        {
            TerugkeerDatum = terugDatum;
            VertrekDatum = vertrekDatum;
            AantalPersonen = aantalPersonen;
        }
        private const double BASISDAGPRIJS = 40;
        public int AantalPersonen { get; set; }
        public int AantalDagen
        {
            get
            {
                TimeSpan ts = TerugkeerDatum - VertrekDatum;
                return ts.Days;
            }
        }
        public DateTime VertrekDatum
        {
            get { return VertrekDatum; }
            set
            {
                if (VertrekDatum <= DateTime.Now)
                {
                    throw new Exception("Dates cannot be in the past");
                }
                VertrekDatum = value;
            }
        }
        public DateTime TerugkeerDatum
        {
            get { return TerugkeerDatum; }
            set
            {
                if (AantalDagen <= 0)
                {
                    throw new Exception("You cannot turn back on the same day. You must stay at least 1 day.");
                }
            }
        }
        public virtual double BerekenPrijs()
        {
            return BASISDAGPRIJS * AantalDagen;
        }

        void IBereken.BerekenPrijs()
        {
            throw new NotImplementedException();
        }
    }
}
