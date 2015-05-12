using DotNetDemo.Async;
using DotNetDemo.Delegate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DotNetDemo
{
    public class Program
    {
        public static decimal InternalAdd(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal InternalMinus(decimal a, decimal b)
        {
            Console.WriteLine("Begin Tid=" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            return a - b;
        }
        public static void Main(string[] args)
        {
            InitEnvironment();

            //====================================================


            MarvelV1 v1 = new MarvelV1();
            v1.Play();

            MarvelV4 v4 = new MarvelV4();
            v4.Play();
           
            

            //====================================================

            //DelegateDemo demo = new DelegateDemo();
            ////将方法绑定给委托
            //demo.Add = new Populate(InternalAdd);
            //demo.Minus = new Populate(InternalMinus);

            //demo.Run();

            //====================================================

            //EventDemo eDemo = new EventDemo();
            //eDemo.Run();
            //====================================================


            //Demo dynamicDemo = new DynamicDemo();
            //dynamicDemo.Run();

            //====================================================

            //Demo buildInDelegateDemo = new BuildInDelegateDemo();
            //buildInDelegateDemo.Run();

            //====================================================

            Demo lambdaDemo = new LambdaDemo();
            lambdaDemo.Run();

            //====================================================

            //Demo asyncDemo = new AsyncDemo();
            //asyncDemo.Run();


            //====================================================

            //Demo parallelDemo = new ParallelDemo.ParallelDemo();
            //parallelDemo.Run();


            Console.ReadKey();
        }

        private static void InitEnvironment()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(120, 40);
            Console.Title = "DotNetDemo";
        }
    }
}
