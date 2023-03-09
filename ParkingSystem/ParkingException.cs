using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystemClassLibrary
{
    public class ParkingException : ApplicationException
    {
        public override string Message
        {
            get => "Your car has been towed away!";
        }
    }
}
