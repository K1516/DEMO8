using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuote tuote = new Tuote();
            Tuote tuote1 = new Tuote { Nimi = "Maito", Hinta = "1,05" };
            Tuote tuote2 = new Tuote { Nimi = "Koppa", Hinta = "10,5" };
            Tuote tuote3 = new Tuote { Nimi = "Kalja", Hinta = "5,0" };

            tuote.AddTuote(tuote1);
            tuote.AddTuote(tuote2);
            tuote.AddTuote(tuote3);

            tuote.PrintCollection();
        }
    }
}
