using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarskaNaloga.Modeli
{
    public class Ocena
    {
        public int Id { get; set; }
        public int DijakId { get; set; }
        public Dijak Dijak { get; set; }

        public int PoucevanjeId { get; set; }
        public Poucevanje Poucevanje { get; set; }

        public int Vrednost {  get; set; }
        public DateTime Datum { get; set; }
    }
}
