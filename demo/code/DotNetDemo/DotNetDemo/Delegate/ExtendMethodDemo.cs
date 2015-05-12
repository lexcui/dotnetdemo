using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo.Delegate
{
    public static class ExtendMethodDemo
    {
        //扩展方法
        public static List<T> ListAllHeroWhere<T>(this List<T> heroList, Predicate<T> predicate)
        {
            return heroList.FindAll(predicate);
        }
    }
}
