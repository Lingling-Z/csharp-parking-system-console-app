using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ParkingSystem
{
    public class NonStaff : Customer
    {
        public NonStaff(double hourlyCharge) 
        { 
            HourlyCharge= hourlyCharge;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("The cost info of non-staff parking {0} hours:", HoursParked);
            Console.WriteLine("    Non-staff Parking    ");
            Console.WriteLine("Pay {0} each hour", HourlyCharge.ToString("C", CultureInfo.CurrentCulture));//display $ sign
            Console.WriteLine("Maximum limit = 24 hours");
            Console.WriteLine("");
        }
    }
}