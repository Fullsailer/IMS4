using ProductClassLibrary;
using System;

namespace IMS4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Product a = new Product("IBM", "Computer", 300.00M);
            Product b = new Product("Apple", "Display", 600.00M);


            Console.WriteLine("Product:"+ " " + p.Manufacturer + " " + p.Model + " " + p.Price);
            Console.WriteLine("Product a is:" +" " + a.Manufacturer + " " + a.Model + " " + a.Price);
            Console.WriteLine("Product b is:" + " " + b.Manufacturer + " " + b.Model + " " + b.Price);

            Console.ReadLine();


        }
    }
}
