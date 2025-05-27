using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandoOOP.model;

namespace CommandoOOP.CommandoOOP.model
{
    public class AirCommando:Commando
    {
        private int HeightToDrop;

        public AirCommando(string name, string codeName, string status, int heightToDrop) : base(name, codeName, status)
        {
            HeightToDrop = heightToDrop;
        }


        public void drop(int height)
        {
            if (height <=HeightToDrop && height > 0)
            {
                Console.WriteLine($"{getcodname("GENERAL")} is droping {height} miters");
            }
            else
            {
                Console.WriteLine("to high to drop");
            }
        }
        public override void Attack()
        {
            Console.WriteLine($"AirCommando {getcodname("GENERAL")} is attaking");
        }
    }
}
