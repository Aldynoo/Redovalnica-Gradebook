using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarskaNaloga
{
    public class AppDbContext : DbContext
    {
        public DbSet<Profesor> Profesorji => Set<Profesor>();
        public DbSet<Dijak> Dijaki => Set<Dijak>();
        public DbSet<Predmet> Predmeti => Set<Predmet>();
        public DbSet<Razred> Razredi => Set<Razred>();
        public DbSet<Oddelek> Oddelki => Set<Oddelek>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=redovalnica.db");
        }
    } 
}
