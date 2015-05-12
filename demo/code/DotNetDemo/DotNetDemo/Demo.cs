using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo
{
    public abstract class Demo
    {
        protected String Name
        {
            get
            {
                return this.GetType().Name;
            }
        }

        protected abstract void Execute();
        public void Run()
        {
            Console.WriteLine();
            
            Console.WriteLine("-=-=-=-这是'{0}'分割线-=-=-=-", Name);

            try
            {
                Execute();
            }
            catch(Exception ex)
            {
                ConsoleColor originalColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.ForegroundColor = originalColor;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
