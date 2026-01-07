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
                //db.Database.EnsureDeleted();
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
                if (!db.Razredi.Any())
                {
                    db.Razredi.AddRange(
                        new Razred { Letnik = 1, Oddelek = "A" },
                        new Razred { Letnik = 1, Oddelek = "B" },
                        new Razred { Letnik = 2, Oddelek = "A" },
                        new Razred { Letnik = 2, Oddelek = "B" },
                        new Razred { Letnik = 3, Oddelek = "A" },
                        new Razred { Letnik = 3, Oddelek = "B" },
                        new Razred { Letnik = 4, Oddelek = "A" },
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
                if (!db.Poucevanja.Any())
                {
                    var prof = db.Uporabniki.FirstOrDefault(u => u.UporabniskoIme == "prof1");
                    var allRazredi = db.Razredi.ToList();
                    var allPredmeti = db.Predmeti.ToList();

                    if (prof != null && allRazredi.Count > 0 && allPredmeti.Count > 0)
                    {
                        var mappings = new List<Poucevanje>();
                        foreach (var razred in allRazredi)
                        {
                            foreach (var predmet in allPredmeti)
                            {
                                mappings.Add(new Poucevanje
                                {
                                    UporabnikId = prof.Id,
                                    RazredId = razred.Id,
                                    PredmetId = predmet.Id
                                });
                            }
                        }

                        db.Poucevanja.AddRange(mappings);
                        db.SaveChanges();
                    }
                }
            }
            Application.Run(new LoginForm());
        }
    }
}