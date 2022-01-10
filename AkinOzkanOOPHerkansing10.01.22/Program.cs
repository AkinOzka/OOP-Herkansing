using AkinOzkanOOPHerkansing10._01._22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinOzkanOOPHerkansing10._01._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon[] personen = new Persoon[3];
            Reisbureau[] reisbureaus = new Reisbureau[1];
            Reis[] reizen = new Reis[2];
          
            personen[0] = new Persoon("Akin", "Ozkan");
            reisbureaus[0] = new Reisbureau("Kgo");
            //reizen[0] = new Reis();
            personen[1] = new Persoon("Kenan", "Kurda");
            PersoonHeader();
            Persoondetail(personen);
        }
        static void Persoondetail(Persoon[]personen)
        {
            foreach (var persoon in personen)
            {
                Console.WriteLine($"{persoon.Naam}");
            }
        }
        static void PersoonHeader()
        {
            string header = $"Gereserveerd door     Aantal Personen        Prijs        Reisbureau Naam";
            Console.WriteLine(header);
        }
    }
}
