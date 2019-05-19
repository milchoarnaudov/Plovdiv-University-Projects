﻿using Game.Models.Common;
using Game.Utility;

namespace Game.Heroes
{
    class Assassin : Hero
    {
        public Assassin(int healthPoints, int attackPoints, int armorPoints)
            : base(healthPoints, attackPoints, armorPoints)
        {
        }

        public override void Attack(Hero opponent)
        {
            if (ChanceDeterminator.Determine(30))
            {
                opponent.Defend(this.AttackPoints * 3);
            }
            else
            {
                 opponent.Defend(this.AttackPoints);
            }
        }
    }
}
