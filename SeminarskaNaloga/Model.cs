using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarskaNaloga
{
    public class Profesor
    {
        public int Id { get; set; }
        public string PriIme { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SluzbeniEmail { get; set; } = string.Empty;
    }
    public class Dijak
    {
        public int Id { get; set; }
        public string PriIme { get; set; } = string.Empty;
        public string Naslov { get; set; } = string.Empty;
        public DateTime DatumRojstva { get; set; }
        public string Telefon { get; set; } = string.Empty;
        public int RazredId { get; set; }
        public Razred Razred { get; set; } 
        public int OddelekId { get; set; }
        public Oddelek Oddelek { get; set; }
    }
    public class Predmet
    {
        public int Id { get; set; }
        public string UcniPredmet { get; set; } = string.Empty;
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
    }
    public class Oddelek
    {
        public int Id { get; set; }
        public string Program { get; set; } = string.Empty;
        public string Crka { get; set; } = string.Empty;
    }
    public class Razred
    {
        public int Id { get; set; }
        public int Letnik { get; set; }
    }
    public class Ocena
    {
        public int Id { get; set; }
        public int Vrednost { get; set; }
        public DateTime Datum { get; set; }
        public int DijakId { get; set; }
        public Dijak Dijak { get; set; }
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
    }
}
