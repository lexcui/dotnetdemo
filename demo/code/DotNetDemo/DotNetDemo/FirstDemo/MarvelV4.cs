using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo
{
    public class SuperSuperHero
    {
        public string Name { get; set; }
        public int Capability { get; set; }
        public Action Attack;
    }
    public class MarvelV4
    {
        public void Play()
        {

            var superHeroList = new List<SuperSuperHero>(){
                    new SuperSuperHero { Name = "Storm", Capability = 80, Attack = ()=> { Console.WriteLine("Thunder and storms..."); } },
                    new SuperSuperHero { Name = "战五渣", Capability = 5, Attack = ()=> { Console.WriteLine("Please don't..."); } }
            };

            beginAttack(superHeroList);
        }

        private void beginAttack(List<SuperSuperHero> superHeroList)
        {
            superHeroList.Where(o => o.Capability > 5).ToList().ForEach(a => a.Attack());
        }
    }
}
