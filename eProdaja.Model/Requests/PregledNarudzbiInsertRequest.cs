using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class PregledNarudzbiInsertRequest
    {
        public int KupciId { get; set; }
        public int ProizvodiId { get; set; }
        public decimal MinIznosNarudzbe { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string BrojNarudzbe { get; set; }
        public decimal IznosNarudzbe { get; set; }
    }
}
