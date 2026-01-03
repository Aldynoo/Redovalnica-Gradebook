using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarskaNaloga.Modeli
{
    public class Dijak
    {
        public int Id {  get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Naslov {  get; set; }
        public string Telefon { get; set; }

        public int RazredId { get; set; }
        public Razred Razred { get; set; }
    }
}
