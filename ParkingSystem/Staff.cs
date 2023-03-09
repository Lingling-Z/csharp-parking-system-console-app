using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ParkingSystem
{
    public class Staff : Customer
    {
        public double BaseFee { get; set; }
        public int BaseHours { get; set; }
        public override double TotalCost
        {
            get => BaseFee + HourlyCharge * (HoursParked - BaseHours);
        }

        public Staff(double hourlyCharge, double baseFee, int baseHours)
        {
            HourlyCharge = hourlyCharge;
            BaseFee = baseFee;
            BaseHours = baseHours;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("The cost info of staff parking {0} hours:", HoursParked);
            Console.WriteLine("    Staff Parking    ");
            Console.WriteLine("Pay {0} for first {1} hours", BaseFee.ToString("C", CultureInfo.CurrentCulture), BaseHours);//display $ sign
            Console.WriteLine("Pay {0} for each hour in excess of {1} hours", HourlyCharge.ToString("C", CultureInfo.CurrentCulture), BaseHours);
            Console.WriteLine("Maximum limit = 24 hours");
            Console.WriteLine("");
        }
    }
}