using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Nave n = new Nave(new TiroSimples());
            n.atirar();


            n.setTiro(new TiroSuper());
            n.atirar();

            n.atirar();

            Nave n2 = new Nave(new TiroSuper());
            n2.atirar();

            Console.ReadKey();

        }
    }
}
