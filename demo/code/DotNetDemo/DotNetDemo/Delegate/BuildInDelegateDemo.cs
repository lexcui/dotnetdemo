using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo.Delegate
{
    public class BuildInDelegateDemo : Demo
    {

        private void singASong5Times(string lyrics)
        {
            for (int i = 0; i < 5;i++ )
                Console.WriteLine("I am singing '{0}'", lyrics);
        }


        protected override void Execute()
        {
            Action<String> act = new Action<string>(singASong5Times);

            act.Invoke("Baby");
        }

        private Action action = new Action(delegate() {});

        private Predicate<int> isPositiveNum = new Predicate<int>(delegate(int d) { return d > 0; });

        private Func<int> sum = new Func<int>(delegate() { return 0; });

        private Func<int, int, int> add = new Func<int, int, int>(delegate(int a, int b) { return a + b; });

        private Converter<int, string> toString = new Converter<int, string>(delegate(int a) { return a.ToString(); });


    }
}
