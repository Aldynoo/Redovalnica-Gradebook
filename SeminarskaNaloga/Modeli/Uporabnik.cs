using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarskaNaloga.Modeli
{
    public class Uporabnik
    {
        public int Id { get; set; }
        public string UporabniskoIme { get; set; }
        public string Geslo {  get; set; }
        public string Vloga { get; set; }
    }
}
