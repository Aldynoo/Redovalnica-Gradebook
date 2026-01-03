using SeminarskaNaloga.Podatki;
using SeminarskaNaloga.Forms;
using SeminarskaNaloga.Modeli;

namespace SeminarskaNaloga
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var db = new AppDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                if (!db.Uporabniki.Any())
                {
                    db.Uporabniki.AddRange(
                        new Uporabnik
                        {
                            UporabniskoIme = "admin",
                            Geslo = "admin",
                            Vloga = "admin"
                        },
                        new Uporabnik
                        {
                            UporabniskoIme = "prof1",
                            Geslo = "prof1234",
                            Vloga = "profesor"
                        });
                    db.SaveChanges();
                }
                if (!db.Uporabniki.Any())
                {
                    db.Razredi.AddRange(
                        new Razred { Letnik = 1, Oddelek = "A" },
                        new Razred { Letnik = 1, Oddelek = "B" },
                        new Razred { Letnik = 2, Oddelek = "B" },
                        new Razred { Letnik = 2, Oddelek = "B" },
                        new Razred { Letnik = 3, Oddelek = "B" },
                        new Razred { Letnik = 3, Oddelek = "B" },
                        new Razred { Letnik = 4, Oddelek = "B" },
                        new Razred { Letnik = 4, Oddelek = "B" });
                    db.SaveChanges();
                }
                if (!db.Predmeti.Any())
                {
                    db.Predmeti.AddRange(
                    new Predmet { Ime = "Matematika" },
                    new Predmet { Ime = "Slovenščina" },
                    new Predmet { Ime = "Angleščina" },
                    new Predmet { Ime = "Ekonomija" }
                    );
                    db.SaveChanges();
                }
            }
            Application.Run(new LoginForm());
        }
    }
}