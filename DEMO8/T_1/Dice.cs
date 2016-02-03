using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_1
{ class Dice
    {
        private Random rnd = new Random();
        public int Roll()
        {

                return rnd.Next(1, 7);
            
        }


    }
}
