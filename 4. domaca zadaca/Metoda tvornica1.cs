using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._domaca_zadaca
{
    using System;
    public interface Champion
    {
        void Attack();
    }

    public class Mech : Champion
    {
        private string specialEffect;
        public Mech(string specialEffect)
        {
            this.specialEffect = specialEffect;
        }
        public void Attack()
        {
            Console.WriteLine($"Attack - {specialEffect}");
        }
    }

    public class Assasin : Champion
    {
        string ability;
        public Assasin(string ability)
        {
            this.ability = ability;
        }
        public void Attack()
        {
            Console.WriteLine($"Attack - {ability}");
        }
    }

    public interface ChampionFactory
    {
        Champion CreateChampion();
    }

    public class MechFactory : ChampionFactory
    {
        private string specialEffect;
        public MechFactory(string specialEffect)
        {
            this.specialEffect = specialEffect;
        }
        public Champion CreateChampion()
        {
            return new Mech(specialEffect);
        }
    }
    public class AssasinFactory : ChampionFactory
    {
        private string ability;
        public AssasinFactory(string ability)
        {
            this.ability = ability;
        }
        public Champion CreateChampion()
        {
            return new Assasin(ability);
        }
    }

    class Program
    {
        static void Main()
        {
            ChampionFactory mechFactory = new MechFactory("Shoot rocket");
            ChampionFactory asassinFactory = new AssasinFactory("Invisible");
            Champion mech = mechFactory.CreateChampion();
            Champion assasin = asassinFactory.CreateChampion();
            mech.Attack();
            assasin.Attack();
        }
    }

}
