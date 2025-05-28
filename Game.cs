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
        EnemyFactory EaF = new EnemyFactory();
        WeaponFactory WF = new WeaponFactory();
        List<string> mamss = new List<string>() { "dsg", "sag", "eagsr", "egsfdg", "wfegfd", "wqefgd", "weqr", "ewdfs" };
        List<Commando> commandos =new List <Commando>() ;
        public void StartGame()
        {
            CF.creatCommando(100);
            EaF.CreateEnemy(mamss, 55);
            WF.CreatWeapn(15);
            commandos = CF.GetListCommando();
          
          

        }
        

    }
}
