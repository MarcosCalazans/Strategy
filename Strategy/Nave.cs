using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Nave
    {
        private TiroStrategy tS;

        public Nave(TiroStrategy t)
        {
            tS = t;
        }

        public void atirar(){
            tS.atirar();
        }

        public void setTiro(TiroStrategy t)
        {
            tS = t;
        }

    }
}
