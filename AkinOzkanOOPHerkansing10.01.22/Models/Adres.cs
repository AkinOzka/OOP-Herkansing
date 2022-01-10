using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinOzkanOOPHerkansing10._01._22.Models
{
    public class Adres
    {
        public Adres(int postcode, string straat, int huisnummer, string gemeente)
        {
            Postcode = postcode;
            Straat = straat;
            Huisnummer = huisnummer;
            Gemeente = gemeente;
        }
        public int Postcode;
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public string Gemeente { get; set; }

    }
}
