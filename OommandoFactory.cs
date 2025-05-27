using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandoOOP.CommandoOOP.model;
using CommandoOOP.model;

namespace CommandoOOP
{
    
    public class CommandoFactory
    {
        Random rnd = new Random();
        private List<Commando> LCommando = new List<Commando>();
        string[] types = new string[] { "Air", "sea", "Commando" };
        string[] Names = new string[] { "af", "wegsa", "egwa", "wages", "wagetsnhrgbf", "wegasd", "ares", "wefagshtnd", "efwasrtnd" };
        string[] Codnams = new string[] { "DFAsgzdFX", "waesgd", "wqASFD", "asfd", "qASD", "asd", "qwes", "wqefgd", "QAWDSF", "QWEFD", "QWDSF" };
        string[] Statuss = new string[] { "alive", "ded" };
        public void createCommando(string type ,string name ,string codeName,string status,int timeInWater,int heightToDrop)
        {
            switch (type)
            {
                case "Air":
                    {
                        LCommando.Add(new AirCommando(name, codeName, status, heightToDrop));
                        break;
                    }
                case "sea":
                    {
                        LCommando.Add(new SeaCommando(name, codeName, status, timeInWater));
                        break;
                    }
                case "Commando":
                    {
                        LCommando.Add(new Commando(name, codeName, status));
                        break;
                    }
            }
           
        }
        public void creat100Com()
        {
            for (int i=0; i<100;i++)
            {
                createCommando(types[rnd.Next(0, 2)], Names[rnd.Next(0, Names.Length - 1)], Codnams[rnd.Next(0, Codnams.Length - 1)], Statuss[rnd.Next(0, 1)], rnd.Next(0, 60), rnd.Next(0, 30000));
            }
        }
        
        


    }
}
