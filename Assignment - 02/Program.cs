/*the Author's name: Jinwook Jung
 *Date last Modified: 6 FEB 2015
 *Program Description: This program present hero's name and randomly select hero's three superpowers.
 *                     Also, when hero's attack is sucess, it shows damage score.
 *Revision History: FEB 3 2015: added superpower array
 *                              Initial commit to add default .gitIgnore and .gitAttribute files.
 *                  FEB 4 2015: added newRandomPower
 *                  FEB 5 2015: fixed generateRandomPowers method
 *                              added internal documentation
 *                  FEB 6 2015: added some code in Program
 *                 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 - IMPLEMENT SuperHero object
            string heroName;
            Console.Write("Enter the Hero name: ");
            heroName = Console.ReadLine();

            SuperHero mySuperHero = new SuperHero(heroName);
            mySuperHero.showPowers();
            Console.WriteLine("-----------------------");
            mySuperHero.fight();

            Console.WriteLine();
            Console.WriteLine("Enter the key to exit");
            Console.ReadKey();
        }
    }
}
