﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___02
{
    class Hero
    {
        // 1-a PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int strength;
        private int speed;
        private int health;


        // 1-c /CONSTRUCTOR METHOD ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name) 
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Hero name is {0}", name);
            Console.WriteLine("-----------------------");
            generateAbilities();
        }
        // 1-b /PUBLIC PROPERTY ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }




        // 1-d /PRIVATE METHOD ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void generateAbilities()
        {
            Random random = new Random();

            this.strength = random.Next(1, 101);
            this.speed = random.Next(1, 101);
            this.health = random.Next(1, 101);
        }
        // 1-e /PUBLIC METHOD ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void fight()
        {

            Random random = new Random();
            int randomNumber = random.Next(0, 6);
            bool attemptSuccess = hitAttempt();
            
            if ( attemptSuccess == true) 
            {
                hitDamage();
                
            } 
            
            Console.WriteLine("Your Hero's damage is {0}!!", hitDamage());
        }
        // 1-f /PUBLIC METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public bool hitAttempt()
 {

            Random random = new Random();
            int randomNumber = random.Next(0, 5);


            switch (randomNumber)
            {
                case 0:
                    return true;
                    
                case 1:
                    return false;
                  
                case 2:
                    return false;
                    
                case 3:
                    return false;
                    
                case 4:
                    return false;
                    
                default:
                    return false;

            }

        }
        // 1-g /PRIVATE METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private int hitDamage()
        {
            int damage;

            Random random = new Random();
            int randomNumber = random.Next(1, 7);

            damage = strength * randomNumber;
            return damage;
        }
        // 1-h /PUBLIC METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void show()
        {
            Console.WriteLine("Your hero's Strength is {0}, Speed is {1}, Health is {2}", strength, speed, health);
        }
    }
}
