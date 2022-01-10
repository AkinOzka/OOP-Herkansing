using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinOzkanOOPHerkansing10._01._22.Models
{
    public class Reisbureau
    {
        private string naam;

        public Reisbureau(string naam)
        {
            this.naam = naam;
        }

        public string Adres { get; set; }
        public string Naam{ get; set; }
    }
}
