using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
   public class Kupci
    {
        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
