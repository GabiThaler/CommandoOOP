using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoOOP.model
{
    public class EnemyFactory
    {
        Random rnd = new Random();
        private List<Enemy> Lenemy = new List<Enemy>(); 

        public void CreateEnemy(List <string> names,int amont)
        {
            for (int i =0; i < amont;i++)
            {
                Lenemy.Add(new Enemy(names[rnd.Next(0,names.Count)])); 
            }
        }

    }
}
