using System;

namespace GeoserverClient.Model
{
    public class Adres
    {
        public string AdresBagId { get; set; }
        public string Nraandid { get; set; }
        public string Oruimteid { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Huisletter { get; set; }
        public string Huisnrtoev { get; set; }
        public string Postcode { get; set; }
        public string Woonplaats { get; set; }
        public int Wnpcode { get; set; }
        public string Gemeente { get; set; }
        public int Gemcode { get; set; }
        public string Provincie { get; set; }
        public int Provcode { get; set; }
        public string Adres_Type { get; set; }
        public string Status { get; set; }
        public int Oppvlakte { get; set; }
        public decimal X_rd { get; set; }
        public decimal Y_rd { get; set; }
        public string Geometrie { get; set; }
        public string GeometrieRD { get; set; }
        public Int64 GebwBagID { get; set; }
    }
}
