using CommandoOOP.CommandoOOP.model;
using CommandoOOP.model;

namespace CommandoOOP
{
    
    class Program
    {
        static void Main()
        {
            //Commando c1 = new Commando("gabi", "gaga", "waking");
            //c1.Attack();
            //c1.Walk();
            //c1.Hide();
            //Weapon w1=new Weapon("M16","IsrelWeapen",44);
            //Console.WriteLine(c1.getcodname("GENERAL"));
            //Console.WriteLine(c1.getcodname("EWbetrgfwe"));
            //c1.setCodeName("gttttt", "GENERAL");
            //Console.WriteLine(c1.getcodname("GENERAL"));
            //c1.setCodeName("gttttt", "omo");
            //Console.WriteLine(c1.getcodname("GENERAL"));
            AirCommando A1 = new AirCommando("neta", "nnn", "grfsd", 7777);
            A1.drop(45);
            A1.drop(4556543);


        }
    }
}
