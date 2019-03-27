using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Schaaktoernooi
{
    public class DatabaseSeeder
    {
        public static void Seed()
        {
            using (SchaakContext context = new SchaakContext())
            {
                context.Database.EnsureCreated();

                MenuItem(context);
                TestData(context);
            }
        }

        private static void MenuItem(SchaakContext context)
        {
            var menuItems = context.MenuItems.OrderBy(x => x.Nummer).ToList();

            //Acteurs toevoegen
            if (!context.MenuItems.Any())
            {
                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 1,
                    Omschrijving = "Admin login"
                });

                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 2,
                    Omschrijving = "Overzicht Schaakclubs"
                });
                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 3,
                    Omschrijving = "Overzicht Schaakclubs"
                });
                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 4,
                    Omschrijving = "Overzicht spelers"
                });
                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 5,
                    Omschrijving = "Overzicht van sponsors"
                });
                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 6,
                    Omschrijving = "Registreren van schaakclub"
                });
                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 7,
                    Omschrijving = "Registeren van speler"
                });
                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 8,
                    Omschrijving = "Registreren van Tornooi"
                });
                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 9,
                    Omschrijving = "Registreren van Sponsor"
                });
                context.MenuItems.Add(new MenuItem
                {
                    Nummer = 10,
                    Omschrijving = "Deelname tornooi meegeven"
                });
                context.SaveChanges();
            }
        }

        private static void TestData(SchaakContext context)
        {
            // sponsor toevoegen aan List_of_Sponsors
            if (!context.List_Of_Sponsors.Any())
            {
                context.List_Of_Sponsors.Add(new List_of_Sponsors
                {
                    SponsorName = "TestSponsor",
                    SponsorPhone = " TestSponsorHpone",
                    OtherSponsorDetails = "TestOtherSponsorDetails"
                });
                context.SaveChanges();

                var testsponsor = context.List_Of_Sponsors.FirstOrDefault(x => x.SponsorName == "TestSponsor");
            }
            

        }

    }
}