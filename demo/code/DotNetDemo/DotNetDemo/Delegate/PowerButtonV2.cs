using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo.Delegate
{
    public class PowerButtonV2
    {
        //定义事件
        public event EventHandler<EventArgs<string>> Clicking;

        protected void OnClicking()
        {
            string status = "clicking";

            fireButtonClickingEvent(status);
        }


        private void fireButtonClickingEvent(string status)
        {
            //包装事件数据并触发事件
            if (Clicking != null)
            {
                EventArgs<string> e = new EventArgs<string>();

                e.Data = "clicking";
                Clicking(this, e);

            }
        }

        public void Click()
        {
            //调用触发事件的位置
            OnClicking();
            Console.WriteLine("Click the button.");

        }
    }

    public class EventArgs<T> : EventArgs
    {
        public T Data
        {
            get;
            set;
        }
    }
}
