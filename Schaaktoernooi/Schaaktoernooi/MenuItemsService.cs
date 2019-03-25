using System;
using System.Collections.Generic;
using System.Text;

namespace Schaaktoernooi
{
    class MenuItemsService
    {
        public List<MenuItems> GetMenuItems()
        {
            using ( context = new ())

            var lstMenuitems = context.MenuItem.OrderBy(x => x.Nummer).ToList();

            return lstMenuitems;
        }

        public void ShowMenu(List<MenuItems> menuItems)

        {
            using (context = new ())

          foreach (var item in menuItems)
        {
            Console.WriteLine(item.Nummer + " " + item.Omschrijving);

       }
    }
}
