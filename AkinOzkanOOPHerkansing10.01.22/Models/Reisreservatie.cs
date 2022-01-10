using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinOzkanOOPHerkansing10._01._22.Models
{
    public class Reisreservatie
    {
        private Reisreservatie reisReservatie;
        public Reisreservatie(Reisreservatie reisReservatie)
        {
            this.reisReservatie = reisReservatie;
        }
        public string Persoon { get; set; }
        public string Reis { get; set; }
        public string Reisbreau { get; set; }
        //public Reisreservatie reisreservatie()
        //{
        //    return $"Reis gereserveerd door {Persoon.Naam} via de bureau {Reisbureau.Naam}";         
        //}
    }
}
