using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schaaktoernooi
{
    class MenuItemsService
    {
        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> lstMenuitems;

            using (SchaakContext context = new SchaakContext())
            {
                lstMenuitems = context.MenuItems.OrderBy(x => x.Nummer).ToList();
            }
            return lstMenuitems;
        }

        public void ShowMenu(List<MenuItem> menuItems)

        {
            using (SchaakContext context = new SchaakContext())

                foreach (var item in menuItems)
                {
                    Console.WriteLine(item.Nummer + " " + item.Omschrijving);

                }
        }

        public void ToonAlleSponsors()
        {
            using (var context = new SchaakContext())
            {
                var sponsors = context.List_Of_Sponsors;

                foreach (var sponsor in sponsors)
                {
                    Console.WriteLine($" { sponsor.SponsorName,25 } { sponsor.SponsorPhone, 15}");
                }
            }
        }

       /* public void RegistrerenVanSponsor(string sponsorNaam)
        {
            using (var context = new SchaakContext())
            {
                var sponsors = context.List_Of_Sponsors.FirstOrDefault(x => x.SponsorName == sponsorNaam);

            }
        }*/
    }
}

