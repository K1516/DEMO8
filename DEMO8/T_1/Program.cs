using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            int luku = dice.Roll();
            Console.WriteLine("How many times u wanna roll the dice? ");
            int amount = int.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++);
            {
                luku = dice.Roll();

                Console.WriteLine("Dice is rolled  {0} times. number was {1}", amount, luku);
                double average = amount + luku;
                double ka = average / amount;
                Console.WriteLine("Your average is {0}", ka);
            }
        }
    }
}
