using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Schaaktoernooi
{
    class SchaakContext: DbContext
    {
        const string server = @"(localdb)\mssqllocaldb";
        const string databaseName = "Schaken";

        DbSet<Users> Users { get; set; }
        DbSet<Toernooi> Toernooi { get; set; }
        DbSet<Club> Club { get; set; }
        DbSet<TournamentsForEachClub> TournamentsForEachClubs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(
               $@"Server={server};Database={databaseName};Trusted_Connection=True;");
        }

        public DbSet <MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
