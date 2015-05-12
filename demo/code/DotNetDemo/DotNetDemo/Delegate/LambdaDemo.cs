using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo.Delegate
{
    public class LambdaDemo : Demo
    {

        private Predicate<int> isPositiveNum0 = new Predicate<int>(delegate(int d) { return d > 0; });  //匿名函数
        private Predicate<int> isPositiveNum1 = new Predicate<int>((int d) => { return d > 0; });       //省略delegate关键字,用=>代替
        private Predicate<int> isPositiveNum2 = new Predicate<int>(d => { return d > 0; });     //用类型推断，省略参数的括号
        private Predicate<int> isPositiveNum3 = new Predicate<int>(d => d > 0);            //...

        #region init
        private List<SuperHero> initHeroList()
        {
            List<SuperHero> result = new List<SuperHero>();
            result.Add(new SuperHero() { Name = "Beast", Capability = 1000, Attack = delegate() { } });
            result.Add(new SuperHero() { Name = "Wolverine", Capability = 10000, Attack = delegate() { Console.WriteLine("/// \\\\\\"); } });

            return result;
        }

        #endregion

        private List<SuperHero> listAllHeroWhere(Predicate<SuperHero> predicate)
        {
            var result = initHeroList();

            return result.FindAll(predicate);
        }

        protected override void Execute()
        {
            var allHeros = initHeroList();
            var superSuperHeros = listAllHeroWhere(superHero => superHero.Capability > 2000);
            superSuperHeros.ForEach(s => Console.WriteLine("Super super hero:" + s.Name));

            //扩展方法
            var wolverine = allHeros.ListAllHeroWhere(superHero => superHero.Name == "Wolverine").First();
            wolverine.Attack();

            //等同于
            var w = ExtendMethodDemo.ListAllHeroWhere(allHeros, superHero => superHero.Name == "Wolverine").First();
            w.Attack();
        }
    }
}
