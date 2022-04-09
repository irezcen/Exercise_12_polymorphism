using System;
using System.Collections.Generic;
using System.Text;

namespace C2_Polimorfizm_mieszkańcy
{
    class Program
    {
        static void Main(string[] args)
        {
            Crossbowman crossbowman1 = new Crossbowman(true);
            Crossbowman crossbowman2 = new Crossbowman(true);
            Crossbowman crossbowman3 = new Crossbowman(false);
            Pikeman pikeman1 = new Pikeman(true);
            Pikeman pikeman2 = new Pikeman(false);
            Civilian civilian1 = new Civilian();
            Civilian civilian2 = new Civilian();
            List<Crossbowman> crossbowmans = new List<Crossbowman>();
            List<Defender> defenders = new List<Defender>();
            List<Inabitant> inhabitants = new List<Inabitant>();
            crossbowmans.Add(crossbowman1);
            crossbowmans.Add(crossbowman2);
            crossbowmans.Add(crossbowman3);
            defenders.Add(pikeman1);
            defenders.Add(pikeman2);
            defenders.Add(crossbowman1);
            defenders.Add(crossbowman2);
            defenders.Add(crossbowman3);
            inhabitants.Add(crossbowman1);
            inhabitants.Add(crossbowman2);
            inhabitants.Add(crossbowman3);
            inhabitants.Add(pikeman1);
            inhabitants.Add(pikeman2);
            inhabitants.Add(civilian1);
            inhabitants.Add(civilian2);
            foreach(Defender i in defenders)
            {
                Console.WriteLine(i.ReadyToFight());
            }
            foreach(Inabitant i in inhabitants)
            {
                Console.WriteLine(i.Eat());
            }
        }
    }
}
