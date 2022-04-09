using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Polimorfizm_mieszkańcy
{
    abstract class Inabitant
    {
        private int food;
        public int Food
        {
            get
            {
                return food;
            }
            set
            {
                if(value > 0)
                {
                    food = value;
                }
                else
                {
                    food = 1;
                }
            }
        }
        public int Eat()
        {
            return food;
        }
        public abstract override string ToString();
        public Inabitant()
        {
            Food = 1;
        }
    }
}
