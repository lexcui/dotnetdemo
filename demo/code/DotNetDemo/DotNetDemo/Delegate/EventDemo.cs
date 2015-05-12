using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DotNetDemo.Delegate
{
    public class EventDemo : Demo
    {

        protected override void Execute()
        {
            PowerButtonV1 powerButton = new PowerButtonV1();
            powerButton.Clicking += powerButton_Clicking;
            powerButton.Clicking += powerButton_Clicking_2;
            powerButton.Click();

            PowerButtonV2 powerButton2 = new PowerButtonV2();
            powerButton2.Clicking += powerButton2_Clicking;
            powerButton2.Click();
        }

        void powerButton2_Clicking(object sender, EventArgs<string> e)
        {
            Console.WriteLine("Current status is " + e.Data);
        }

        private void powerButton_Clicking(object sender, ButtonClickEventArgs e)
        {
            Console.WriteLine("Current status is " + e.Data);

        }
        private void powerButton_Clicking_2(object sender, ButtonClickEventArgs e)
        {
            Console.WriteLine("Repeat current status is " + e.Data);

        }

    }
}
