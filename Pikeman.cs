using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Polimorfizm_mieszkańcy
{
    class Pikeman:Defender
    {
        public override string ToString()
        {
            return "I am pikeman";
        }
        public override string ReadyToFight()
        {
            if (IsReadyToFight)
            {
                return "My pike is ready!";
            }
            else
            {
                return "My pike isn't ready";
            }
        }
        public Pikeman(bool _isReadyToFight) : base(_isReadyToFight)
        {
            Food++;
        }
    }
}
