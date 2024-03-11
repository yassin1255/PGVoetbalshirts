using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalshirts_BL.Models
{
    public class Klant
    {
        private int _klantId;
        private string _naam;
        private string _adres;
        public int KlantId 
        { 
            get
            {
                return _klantId;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("klantId moet groter dan 0 zijn");
                }
            }
        }
        public string Naam 
        { 
            get
            {
                return _naam;
            } 
            set
            {
                if (string.IsNullOrWhiteSpace(value)) 
                {
                    throw new ArgumentNullException("Naam mag niet leeg zijn");
                }
                _naam = value;
            }
        }
        public string Adres 
        {
            get
            {
                return _adres;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentNullException("Adres mag niet leeg zijn en moet minstens 5 karakters hebben");
                }
                _adres = value;
            }
        }
        public List<Bestelling> Bestellingen { get; set; }
        public Klant(int klantid, string naam, string adres) 
        { 
            KlantId = klantid;
            Naam = naam;
            Adres = adres;
            Bestellingen = new List<Bestelling>();
        }
        public int TotaalAantalBestellingen()
        {
            return Bestellingen.Count;
        }
        public decimal TotaalUitgegevenBedrag()
        {
            decimal totaal = 0;

            foreach (var bestelling in Bestellingen)
            {
                totaal += bestelling.AangerekendePrijs;
            }
            return totaal;
        }
    }
}
