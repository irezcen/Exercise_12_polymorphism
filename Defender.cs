using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Polimorfizm_mieszkańcy
{
    abstract class Defender:Inabitant
    {
        private bool isReadyToFight;
        public bool IsReadyToFight
        {
            get
            {
                return isReadyToFight;
            }
            set
            {
                isReadyToFight = value;
            }
        }
        public abstract string ReadyToFight();
        public Defender(bool _isReadyToFight) : base()
        {
            Food++;
            IsReadyToFight = _isReadyToFight;
        }
    }
}
