/*the Author's name: Jinwook Jung
 *Date last Modified: 5 FEB 2015
 *Program Description: 
 *Revision History: 
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
            SuperHero mySuperHero = new SuperHero("Jinwook");
            mySuperHero.showPowers();
            mySuperHero.fight();
        }
    }
}
