using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class TiroSimples : TiroStrategy
    {
        public void atirar()
        {
            Console.WriteLine("Atirei simplesmente...");
        }
    }
}
