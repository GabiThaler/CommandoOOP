using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoOOP.model
{
    public class Commando
    {
        private string Name;
        private string CodeName { get; set; }
        private string[] tools = new string[5];
        private string Status;

        public Commando(string name, string codeName, string status)
        {
            Name = name;
            CodeName = codeName;
            this.tools = ["hammer", "chisel", "rope", "bag", "water bottle"];
            if (status == "walking" || status == "hiding")
            {
                Status = status;
            }
        }
        public string SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                return Name;
            }
            else if(commanderRank == "COLONEL")
            {
                return CodeName;
            }
            return "you dont have raits to get the name!";
        }

        public string getcodname(string commanderRank)
        {
            if (commanderRank == "GENERAL" || commanderRank == "COLONEL")
            {
                return CodeName;
            }
            return "you have no raits to get the cod name";
        }

        public void setCodeName(string newCodename,string commanderRank)
        {
            if (commanderRank == "GENERAL" )
            {
                CodeName = newCodename;
            }
        }


        public void Walk()
        {
            Console.WriteLine("the soldier is walking!");
            Status = "walking";
        }

        public void Hide()
        {
            Console.WriteLine("the soldier is hiding!");
            Status = "hiding";
        }

        public void Attack()
        {
            Console.WriteLine($"commando {CodeName} is attackimg!");
        }
    }
}
