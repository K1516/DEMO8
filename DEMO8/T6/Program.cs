using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuote tuote = new Tuote();
            Console.WriteLine("What u order?");
            Console.WriteLine("1. Add order");
            Console.WriteLine("2. Check please");
            string rivi = Console.ReadLine();
            int luku = int.Parse(rivi);
            if (luku == 1)
            { 
                Console.WriteLine("Name?");
                string Name = Console.ReadLine();
                string name = tuote.Name;
                Console.WriteLine("Price");
            string hinta = Console.ReadLine();
                double price = tuote.Price;
            Console.WriteLine("How many?");
                string määrä = Console.ReadLine();
                int Määrä = tuote.Quantity;
                return Main;
        }
            else
{
                double total = tuote.Price * tuote.Quantity;
                Console.WriteLine("It is " + total + " euros");
            }



        }
    }
}
