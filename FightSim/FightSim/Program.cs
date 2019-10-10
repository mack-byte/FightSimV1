using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter();//Skapar en kämpe
            Fighter f2 = new Fighter();
            Console.WriteLine("Name fighter 1");
            f1.name = Console.ReadLine();//Lagrar spelarens input i name variablen
            Console.WriteLine("Name fighter 2");
            f2.name = Console.ReadLine();
            
            while (f2.Alive() == true && f1.Alive() == true) //Ifall båda spelarna är vid liv så körs loopen
            {

                
                f1.Attack();//Kallar metoden för attack
                
                f2.Hurt1(f1.Attack());//Använder attack som parameter för hur mycket hp som ska dras av 
                Thread.Sleep(1000);//Skapar mellanrum mellan varje slag
                Console.WriteLine(f2.name + " has " + f2.GetHp() + " HP");//skriver ut hur mycket hp spelarna har
                f2.Attack();
                
                f1.Hurt1(f2.Attack2());
                Console.WriteLine(f1.name + " has " + f1.GetHp() + " HP");
                
                
            }
            if (f2.Alive() == false)
            {
                Console.WriteLine("Congrats " + f1.name);
            }
            if (f1.Alive() == false)
            {
                Console.WriteLine("Congrats " + f2.name);
            }

            Console.ReadLine();

        }
    }
}
