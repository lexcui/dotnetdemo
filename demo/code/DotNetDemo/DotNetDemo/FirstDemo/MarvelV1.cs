using System;
using System.Collections;

namespace DotNetDemo
{

    public delegate void SuperAbility();

    public class SuperHero
    {
        private string name;
        private int capability;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Capability
        {
            get { return capability; }
            set { capability = value; }
        }

        public SuperAbility Attack;
        
    }

    public class MarvelV1
    {
        public void Play()
        {
            ArrayList superHeroList = new ArrayList();

            SuperHero hero1 = new SuperHero();
            hero1.Name = "Storm";
            hero1.Capability = 80;
            hero1.Attack = new SuperAbility(ThunderStorms);

            superHeroList.Add(hero1);

            SuperHero hero2 = new SuperHero();
            hero2.Name = "战五渣";
            hero2.Capability = 5;
            hero2.Attack = new SuperAbility(Talk);

            superHeroList.Add(hero2);


            beginAttack(superHeroList);

        }

        private void beginAttack(ArrayList superHeroList)
        {
            foreach(Object o in superHeroList)
            {
                if( o is SuperHero)
                {
                    SuperHero hero = (SuperHero)o;

                    if (hero.Capability > 5)
                    {
                        hero.Attack.Invoke();
                    }
                }
            }
        }

        private void ThunderStorms()
        {
            Console.WriteLine("Thunder and storms...");
        }

        private void Talk()
        {
            Console.WriteLine("Please don't...");
        }
    }
}
