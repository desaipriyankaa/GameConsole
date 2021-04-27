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

            PlayerCharacter suraj = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Suraj"
            };

            PlayerCharacter vishu = new PlayerCharacter(new NullDefence())
            {
                Name = "Vishu"
            };

            priyanka.Hit(10);
            suraj.Hit(10);
            vishu.Hit(10);
        }
    }
}
