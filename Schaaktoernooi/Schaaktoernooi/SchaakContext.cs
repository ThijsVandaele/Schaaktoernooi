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

       public DbSet<Users> Users { get; set; }
       public DbSet<Toernooi> Toernooi { get; set; }
       public DbSet<Club> Club { get; set; }
       public DbSet<TournamentsForEachClub> TournamentsForEachClubs { get; set; }
       public DbSet<List_of_Sponsors> List_Of_Sponsors { get; set; }

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
