using System;
using System.Collections.Generic;
using System.Linq;
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
        
        public void StartGame()
        {
            CF.creat100Com();
            EaF.CreateEnemy(mamss, 55);
            WF.CreatWeapn(15);

        }
        

    }
}
