using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo.Delegate
{

    //定义事件处理程序的委托
    public delegate void ButtonClickEventHandler(object sender, ButtonClickEventArgs e);
    public class PowerButtonV1
    {
        //定义事件
        public event ButtonClickEventHandler Clicking;

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
                ButtonClickEventArgs e = new ButtonClickEventArgs();
                
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

    //事件数据
    public class ButtonClickEventArgs : EventArgs
    {
        public string Data
        {
            get;
            set;
        }
    }
}
