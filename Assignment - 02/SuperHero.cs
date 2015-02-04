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

        public Hero(string name)
        {
            generateRandomPowers();
        }

        private string[] generateRandomPowers()
        {
            string[] randomPowers = {"Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "WeatherControl"};
            
            Random rnd = new Random();

            
            int secondRandomNumber = rnd.Next(6);
            int thirdRandomNumber = rnd.Next(6);
            
            for(int index = 0; index < 3; index++)
            {
                int firstRandomNumber = rnd.Next(6);
                string firstRandomPowers = randomPowers[index];
                
                string secondRandomPowers = randomPowers[index];
                string thirdRandomPowers = randomPowers[index];
            }

            public void showPowers()
            {
                Console.WriteLine("Hero's Superpowers are {0}, {1}, {2}",,,);
            }

        }
     }
}
