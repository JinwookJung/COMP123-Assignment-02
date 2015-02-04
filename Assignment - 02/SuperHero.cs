using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___02
{
    class SuperHero
    {
        private string superPower;

        public SuperHero(string name)
        {
            SuperHero mySuperHero = new SuperHero("Jinwook");
            generateRandomPowers();
        }

        private void generateRandomPowers()
        {
            string[] randomPowers = {"Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "WeatherControl"};
            string[] newRandomPowers = new string[3]; 
            

            
            for(int index = 0; index < 3; index++)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(6);
                
                if (randomPowers[randomNumber] != "unavailable")
                {
                    
                    newRandomPowers[index] = randomPowers[index];
                    randomPowers[index] = "Unavailable";
                    
                    Console.WriteLine(newRandomPowers[index]);
                } 
                
                
            }
        }

            public void showPowers()
            {
               
                for(int index = 0; index < newRandomPowers.Length; index++ )
               Console.WriteLine(newRandomPowers[index]);
            }

        }
     }
}
