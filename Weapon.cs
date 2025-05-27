using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoOOP.model
{
    public class Weapon
    {
        private string Name;
        private string BrandName;
        private int NumOfBulits;


        public Weapon(string name, string brandName, int numOfBulits)
        {
            Name = name;
            BrandName = brandName;
            NumOfBulits = numOfBulits;
        }

        public void Shoot()
        {
            Console.WriteLine("bommmmmmmmmmmm tshhhhhhhhhhhhhhh");
            NumOfBulits -= 1;
        }
    }
}
