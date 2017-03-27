using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine($"Player: {player}");

            WeaponComponent playerWithWeapon = new WeaponComponent(player);
            Console.WriteLine($"Player with weapon: {playerWithWeapon}");

            ShieldComponent playerWithShield = new ShieldComponent(player);
            Console.WriteLine($"Player with shield: {playerWithShield}");

            ShieldComponent playerWithWeaponAndShield = new ShieldComponent(playerWithWeapon);
            Console.WriteLine($"Player with weapon and shield: {playerWithWeaponAndShield}");
        }
    }
}
