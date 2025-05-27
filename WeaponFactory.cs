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

        private List<Weapon> Lweapons = new List<Weapon>();
        string[] name = new string[] { "m16", "mag4", "4om", "sadf" };
        string[] brandName = new string[] { "ads", "dasf", "dasdv", "dasf" };
        Random rnd = new Random();
        public void CreatWeapn(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Lweapons.Add(new Weapon(name[rnd.Next(0, name.Length)], brandName[rnd.Next(0, brandName.Length)], 100));
            }
        }

    }
}
