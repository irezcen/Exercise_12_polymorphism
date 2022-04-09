using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Polimorfizm_mieszkańcy
{
    class Civilian:Inabitant
    {
        public override string ToString()
        {
            return "I am civilian";
        }
        public Civilian() : base()
        {
        }
    }
}
