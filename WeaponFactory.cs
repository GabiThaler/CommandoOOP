using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandoOOP.model;

namespace CommandoOOP
{
    public class WeaponFactory
    {

        private List<Weapon> weapons = new List<Weapon>();
       

        Random rnd = new Random();
        public void CreatWeapn(int amount, string type)
        {
            if (type.ToLower() == "M16")
            {
                for (int i = 0; i < amount; i++)
                {
                    weapons.Add(new Weapon("M16", "COLT", 29));
                }
            }
            else if (type.ToLower() == "AK47")
            {
                for (int i = 0; i < amount; i++)
                {
                    weapons.Add(new Weapon("AK47","KALASHNIKVOV", 30));
                }
            }
        }

        public List<Weapon> GetWeapans()
        {
            return weapons;
        }

 
    }
}
