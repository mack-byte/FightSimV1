using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {
        int hp = 100;
        
        public string name;
        


        Random generator = new Random();

        public void Attack()
        {
            int r = generator.Next(50);
        }
        public int Hurt1(int r)
        {
            hp -= r;
            return r;
        }
        
        public bool Alive()
        {
            if (hp < 0)
            {
                return false;
            }
            
            return true;
        }
        public int GetHp()
        {
            return hp;
        }
        
        
       

    }

 }
