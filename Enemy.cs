using System;
using System.Security.Cryptography.X509Certificates;


namespace CommandoOOP.model
{
    
    public class Enemy 
    {
        private string Name { get; }
        private int Life = 100;
        private string status = "a live";


        public Enemy (string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void shout()
        {
            Console.WriteLine("I am an anemy!!!!!!!!!!!!");
        }
    }
}
