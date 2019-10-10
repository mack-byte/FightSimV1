using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter();
            Fighter f2 = new Fighter();
            Console.WriteLine("Name fighter 1");
            f1.name = Console.ReadLine();
            Console.WriteLine("Name fighter 2");
            f2.name = Console.ReadLine();
            Console.WriteLine(f1.name + f2.name);
            while (f1.Alive() == true)
            {
                
            }

            Console.ReadLine();

        }
    }
}
