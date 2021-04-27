using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly ISpecialDefence _specialDefence;
        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public string Name { get; set; }
        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            //int damegeReduction = 0;
            //if (_specialDefence != null)
            //{
            //    damegeReduction = _specialDefence.calculateDemageReduction(damage);
            //}
            //int totaldamageTaken = damage - damegeReduction;


            int totalDamageTaken = damage - _specialDefence.calculateDemageReduction(damage);
            Health -= totalDamageTaken;
            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }
    }
}
