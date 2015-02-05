using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___02
{
    class SuperHero : Hero
    {
        string[] superPower = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "WeatherControl" };
        string[] newRandomSuperPower = new string[3];
        
        public SuperHero(string name) : base(name)
        {
            
            generateRandomPowers();
        }

        private void generateRandomPowers()
        {
            
            
           
            for (int index = 0; index < 3; index++)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(6);

                if (superPower[randomNumber] != "Unavailable")
                {
                    newRandomSuperPower[index] = superPower[randomNumber];
                    superPower[randomNumber] = "Unavailable";

                    //Console.WriteLine(newRandomSuperPower[index]);

                }else{
                    index = index - 1;
                }
            }
        }

        public void showPowers()
        {

            for (int index = 0; index < newRandomSuperPower.Length; index++)
            {
                Console.WriteLine(newRandomSuperPower[index]);
            }
            
        }
    }
}