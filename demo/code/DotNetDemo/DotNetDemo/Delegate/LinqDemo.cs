using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetDemo.Delegate
{
    public class LinqDemo : Demo
    {
        protected override void Execute()
        {
            List<Phone> phones = new List<Phone>();
 	        //init

            var myPhoneOrder = from p in phones
                                  where p.ScreenInch > 5 && p.StandbyHours > 48
                                  select new OrderDetail() { SelectedPhone = p}; 
        }
    }

    public class OrderDetail 
    {
        public Phone SelectedPhone { get; set; }
    }

    public class Phone
    {
        public int ScreenInch { get; set; }
        public string Resolution { get; set; }
        public String Brand { get; set; }
        public int StandbyHours { get; set; }
    }
}
