using System;
using Tests;

namespace FactoryPattern
{
    public class MyWebSite : IMyWebSite
    {
        public void BookMovies()
        {
            Console.WriteLine("BookMovies");
        }

        public void CalculatePrice()
        {
            Console.WriteLine("8");
        }
    }
}