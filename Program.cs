using CommandoOOP.CommandoOOP.model;
using CommandoOOP.model;

namespace CommandoOOP
{
    
    class Program
    {
        static void Main()
        {
            
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
            SeaCommando s1 = new SeaCommando("gabi", "efvds", "hinjrwenv", 44);
            Commando c1 = new Commando("gabi", "gaga", "waking");
            Commando[] ArryCommondo = new Commando[] {A1,s1,c1};
            

            



        }
    }
}
