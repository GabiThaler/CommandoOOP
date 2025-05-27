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
        private string CodeName;
        private string[] tools = new string[5];
        private string status;

        public Commando(string name, string codeName, string status)
        {
            Name = name;
            CodeName = codeName;
            this.tools = ["hammer", "chisel", "rope", "bag", "water bottle"];
            this.status = status;
        }

        public void Walk()
        {
            Console.WriteLine("the soldier is walking!");
            status = "walking";
        }

        public void Hide()
        {
            Console.WriteLine("the soldier is hiding!");
            status = "hiding";
        }

        public void Attack()
        {
            Console.WriteLine($"commando {CodeName} is attackimg!");
        }
    }
}
