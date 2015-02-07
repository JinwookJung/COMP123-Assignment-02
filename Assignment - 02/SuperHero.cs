using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___02
{
    class SuperHero : Hero
    {
        // 1-a: PRIVATE PROPERTIES
        private string[] superPower = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "WeatherControl" };
        private string[] newRandomSuperPower = new string[3];

        // 1-b: CONSTRUCTOR METHOD
        public SuperHero(string name) : base(name)
        {
            generateRandomPowers();
        }
        // 1-c: generateRandomPowers METHOD
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

                }else{
                    index = index - 1;
                }
            }
        }
        //1-d: public showPowers method
        public void showPowers()
        {

            for (int index = 0; index < newRandomSuperPower.Length; index++)
            {
                Console.WriteLine("Superpower is {0}",newRandomSuperPower[index]);
            }
            
        }
    }
}