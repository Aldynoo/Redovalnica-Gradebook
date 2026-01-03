using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarskaNaloga.Modeli
{
    public class Poucevanje
    {
        public int Id { get; set; }

        public int UporabnikId { get; set; }
        public Uporabnik Profesor {  get; set; }

        public int RazredId { get; set; }
        public Razred Razred { get; set; }

        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
    }
}
