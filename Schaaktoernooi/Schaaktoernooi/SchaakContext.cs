using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Schaaktoernooi
{
    class SchaakContext: DbContext
    {
        const string server = @"(localdb)\mssqlllocaldb";
        const string databaseName = "Schaken";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(
               $@"Server={server};Database={databaseName};Trusted_Connection=True;");
        }
    }
}
