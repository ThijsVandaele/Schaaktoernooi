using System;

namespace Schaaktoernooi
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseSeeder.Seed();

            var service = new MenuItemsService();

            service.ToonAlleSponsors();

            Console.ReadKey();
        }
    }
}
