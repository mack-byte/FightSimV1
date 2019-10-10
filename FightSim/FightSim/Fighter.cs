using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FightSim
{
    class Fighter
    {
        int hp = 100; //variabel för hur mycket hp båda börjar med
        
        public string name; //string för att lagra de namn som spelaren skriver in
        

        
        Random generator = new Random(); //Slumpar hur mycket skada man gör
        Random generator2 = new Random();

        public int Attack() //Metod för attacken där båda spelarna kan göra mellan 0 och 50 skada
        {
            
            int amount = generator.Next(50);
            return amount;
        }
        public int Attack2()
        {

            int amount = generator2.Next(50);
            return amount;
        }
        public void Hurt1(int amount) //Metod för att dra av antalet ska från hp
        {
           
            hp -= amount;
            
        }
        
        public bool Alive() //Boolvärde för att avgöra ifall spelaren är vid liv
        {
            if (hp < 1)
            {
                return false;// ifall hp är under 1 så kommer den returnera false
            }
            else
            {
                return true;
            }
            
        }
        public int GetHp() //Metod för att returnera den privata inten
        {
            return hp;
        }
        
        
       

    }

 }
