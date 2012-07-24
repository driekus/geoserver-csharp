using System;
using System.Collections.Generic;

namespace GeoserverClient.Model
{
    public class Gebouw
    {
        public Int64 GebwBagID { get; set; }
        public int Pc4Code { get; set; }
        public string Woonplaats { get; set; }
        public int WnpCode { get; set; }
        public string Gemeente { get; set; }
        public int GemCode { get; set; }
        public string Provincie { get; set; }
        public int ProvincieCode { get; set; }
        public int Bouwjaar { get; set; }
        public string Gebw_Type { get; set; }
        public string Status { get; set; }
        public int Oppvlakte { get; set; }
        public string Geometrie { get; set; }
        public string GeometrieRD { get; set; }
        public List<Adres> Adressen { get; set; }
    }
}
