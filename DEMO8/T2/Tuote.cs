using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Tuote
    {
        public string Nimi { get; set; }
        public string Hinta { get; set; }
        public List<Tuote> tuote;
        public Tuote()
        {
            tuote = new List<Tuote>();
        }
        public void AddTuote(Tuote tuotteet)
        {
            tuote.Add(tuotteet);
        }


        public void PrintCollection()
        {
            
            foreach (Tuote tuotteet in tuote)
            {
                Console.WriteLine(tuote.ToString());
            }
        }
    }
}
