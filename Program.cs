using System;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter priyanka = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Priyanka"
            };

            PlayerCharacter suraj = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Suraj"
            };

            PlayerCharacter vishu = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Vishu"
            };

            priyanka.Hit(10);
            suraj.Hit(10);
            vishu.Hit(10);
        }
    }
}
