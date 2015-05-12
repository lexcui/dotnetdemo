using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo.Delegate
{
    //声明委托
    public delegate decimal Populate(decimal a, decimal b);

    public class DelegateDemo : Demo
    {
        //用委托声明两个成员
        public Populate Add;
        public Populate Minus;

        protected override void Execute()
        {
            //Invoke
            Console.WriteLine(Add==null?"":"3+6=" + Add.Invoke(3, 6));  //Invoke

            //BeginInvoke & EndInvoke
            IAsyncResult ar = Minus.BeginInvoke(3, 6, null, null);
            decimal result = Minus.EndInvoke(ar);

            Console.WriteLine("End Tid=" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(Minus == null ? "" : "3-6=" + result);

            //BeginInvoke & EndInvoke
            string tid = System.Threading.Thread.CurrentThread.ManagedThreadId.ToString();
            Minus.BeginInvoke(3, 6, new AsyncCallback(DisplayResult), tid);
            
        }

        private void DisplayResult(IAsyncResult ar)
        {
            Console.WriteLine("Callback Parent Tid=" + ar.AsyncState);
            Console.WriteLine("Callback End Tid=" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("3-6=" + Minus.EndInvoke(ar) );
            
        }


    }
}
