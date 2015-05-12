using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo.Delegate
{
    public class DynamicDemo : Demo
    {
        protected override void Execute()
        {
            dynamic now = DateTime.Now;

            Console.WriteLine("Current Time is: " + now.ToString("yy-MM-dd HH:mm:ss"));

            Console.WriteLine("dynamic object's name is {0}", GetSomeone().Name);

            Console.WriteLine("dynamic object 4's name is {0}", GetNameList().Single<dynamic>(i=> i.Id == 4).Name);

            Console.WriteLine(GetSomeone().Age);

            
        }

        public dynamic GetSomeone()
        {
            return new { Id = 1, Name = "Jenny" };
        }

        public List<dynamic> GetNameList()
        {
            var nameList = new List<dynamic>() { new { Id  = 1, Name = "Lex" , Age = 33 } };
            nameList.Add(new { Id = 2, Name = "John" });
            nameList.Add(new { Id = 3, Name = "Lewis" });
            nameList.Add(new { Id = 4, Name = "Mathew" });

            return nameList;
        }
    }
}
