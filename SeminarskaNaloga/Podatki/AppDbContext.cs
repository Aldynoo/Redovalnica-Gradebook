using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SeminarskaNaloga.Modeli;

namespace SeminarskaNaloga.Podatki
{
    public class AppDbContext : DbContext
    {
        public DbSet<Uporabnik> Uporabniki { get; set; }
        public DbSet<Razred> Razredi { get; set; }
        public DbSet<Dijak> Dijaki { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Poucevanje> Poucevanja { get; set; }
        public DbSet<Ocena> Ocene { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=redovalnica.db");
        }
    }
}
