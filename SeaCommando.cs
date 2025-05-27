using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoOOP.model
{
    internal class SeaCommando:Commando
    {
        private int TimeInWater;

        public SeaCommando(string name, string codeName, string status,int timeInWater):base(name,codeName,status)
        {
            TimeInWater = timeInWater;
        }

        public void GoInToWater(int time)
        {
            if (time  <= TimeInWater && time>0)
            {
                Console.WriteLine($"commando {getcodname("GENERAL")} is going in to water");
            }
            else
            {
                Console.WriteLine("not alod in to aeter");
            }
        }
        public override void Attack()
        {
            Console.WriteLine($"seaCommando {getcodname("GENERAL")} is attaking");
        }
    }
}
