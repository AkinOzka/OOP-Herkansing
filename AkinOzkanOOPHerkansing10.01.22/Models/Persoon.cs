using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinOzkanOOPHerkansing10._01._22.Models
{
    public class Persoon
    {
        public Persoon(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public string Naam
        {
            get { return Voornaam + " " + Familienaam; }
        }
    }
}
