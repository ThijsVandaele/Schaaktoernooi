﻿using System;

namespace Schaaktoernooi
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseSeeder.Seed();
            
            Console.ReadKey();
        }
    }
}
