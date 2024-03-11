using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalshirts_BL.Models
{
    public class Shirts
    {
        private decimal _kostprijs;
        public string Competitie { get; set; }
        public string Set {  get; set; }
        public string Maat { get; set; }
        public string Seizoen { get; set; }
        public decimal Kostprijs 
        { 
            get
            {
                return _kostprijs;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Kostprijs kan niet negatief zijn");
                }
                _kostprijs = value;
            }
        }
        public Shirts(string competitie, string set, string maat, string seizoen, decimal kostprijs)
        {
            Competitie = competitie;
            Set = set;
            Maat = maat;
            Seizoen = seizoen;
            Kostprijs = kostprijs;
        }
    }
}
