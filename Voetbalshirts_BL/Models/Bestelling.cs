using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voetbalshirts_BL.Interfaces;

namespace Voetbalshirts_BL.Models
{
    public class Bestelling : IKortingBerekenen
    {
        private decimal _aangerekendeprijs;
        public int BestellingsNr { get; set; }
        public DateTime BestellingsDatum { get; set; }
        public bool IsBetaald { get; set; }
        public decimal AangerekendePrijs 
        { 
            get
            {
                return _aangerekendeprijs;
            } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Aangerekende prijs kan niet negatief zijn");
                }
                _aangerekendeprijs = value;
            }
        }
        public List<Shirts> Shirts { get; set; }
        public Klant Klant { get; set; }
        public Bestelling(int bestellingsNr, DateTime bestellingsdatum, bool isBetaald, decimal aangerekendePrijs, Klant klant)
        {
            BestellingsNr = bestellingsNr;
            BestellingsDatum = bestellingsdatum;
            IsBetaald = isBetaald;
            AangerekendePrijs = aangerekendePrijs;
            Shirts = new List<Shirts>();
            Klant = klant;
        }
        public void BerekenenKorting(int aantalBestellingen)
        {
            aantalBestellingen = Klant.Bestellingen.Count;
            decimal korting = 0;

            if (aantalBestellingen > 10)
            {
                korting = 0.20m;
            }
            else if (aantalBestellingen > 5)
            {
                korting = 0.10m;
            }
            AangerekendePrijs = AangerekendePrijs - (AangerekendePrijs * korting);
        }
    }
}
