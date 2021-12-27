using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class TiroSuper : TiroStrategy
    {
        public void atirar()
        {
            Console.WriteLine("Super Tiro!");
        }
    }
}
