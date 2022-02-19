using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
   public class Narudzbe
    {
        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KupacId { get; set; }
        public Kupci Kupac { get; set; }
        public DateTime Datum { get; set; }
        public decimal UkupanIznos { get; set; }
    }
}
