using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CommandoOOP.model
{
    internal class Game
    {
        CommandoFactory CF = new CommandoFactory();
        EnemyFactory EF = new EnemyFactory();
        WeaponFactory WF = new WeaponFactory();
        List<Enemy> Enemys = new List<Enemy>();
        List<Weapon> Weapens = new List<Weapon>() ;
        List<Commando> Commandos =new List <Commando>() ;
        public void StartGame()
        {
            

            CF.creatCommando(100);
            EF.CreateEnemy( 55);
            WF.CreatWeapn(35,"M16");
            WF.CreatWeapn(35, "AK47");
            Commandos = CF.GetListCommando();
            Enemys = EF.GetListEnemy();
            Weapens = WF.GetWeapans();
            Commandos[4].Walk();
            Commandos[2].Hide();
            Commandos[5].Attack(Enemys[3]);
            
          
          

        }
        

    }
}
