using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Polimorfizm_mieszkańcy
{
    class Crossbowman:Defender
    {
        public override string ToString()
        {
            return "I am crossbowman";
        }
        public override string ReadyToFight()
        {
            if (IsReadyToFight)
            {
                return "My crossbow is ready!";
            }
            else
            {
                return "My crossbow isn't ready";
            }
        }
        public Crossbowman(bool _isReadyToFight) : base(_isReadyToFight)
        {

        }
    }
}
