using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Database
{
    public class PregledNarudzbi
    {
        public int PregledNarudzbiId { get; set; }
        public int KupciId { get; set; }
        public Kupci Kupci { get; set; }
        public int ProizvodiId { get; set; }
        public Proizvodi Proizvodi { get; set; }
        public decimal MinIznosNarudzbe { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string BrojNarudzbe { get; set; }
        public decimal IznosNarudzbe { get; set; }
    }
}
