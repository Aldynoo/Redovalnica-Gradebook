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
        public string Naslov { get; set; }
        public DateTime DatumRojstva { get; set; }
        public int Telefon { get; set; }
        public Razred Razred { get; set; } = null;
        public Oddelek Oddelek { get; set; }
    }
    public class Predmet
    {
        public int Id { get; set; }
        public string UcniPredmet { get; set; } = string.Empty;
        public int Ocena { get; set; }
    }
    public class Oddelek
    {
        public int Id { get; set; }
        public string Program { get; set; }
        public string Crka { get; set; }
    }
    public class Razred
    {
        public int Id { get; set; }
        public int Letnik { get; set; }
    }
    public class Izposoja
    {
        public int Id { get; set; }
        public int KnjigaId { get; set; }
       // public Knjiga Knjiga { get; set; } = null;
        public int BralecId { get; set; }
       // public Bralec Bralec { get; set; }
        public DateTime DatumIzposoje { get; set; }
        public DateTime DatumVrnitve { get; set; }
    }
}
