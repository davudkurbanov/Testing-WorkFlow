using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;

namespace WBA.PE2.KurbanovD.Domain.Base
{
     public abstract class CardUnit : Card
    {
        public double Mana { get; set; }
        public double Manaregen { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
        public DamageType DamageType { get; set; }
        public double Armor { get; set; }
        public double HealthRegen { get; set; }
        public string Description { get; set; }
        public HeroRace Race { get; set; }
        public List<CardUnitSkills> SkillSet { get; set; }

        //public CardUnit(string name,double health,double damage) :base(name)
        //{
        //    Health = health;
        //    Damage = damage;
        //    Armor = 1;
        //    HealthRegen = 1;
        //    Mana = 0;
        //    Manaregen = 0.5;
        //}

    }
}
