using ParkingSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ParkingSystem
{
    public abstract class Customer
    {
        private double _hoursParked;
        private double _hourlyCharge;
        private bool _isTowedAway;
        private double _totalCost;

        public double HourlyCharge 
        { 
            get => _hourlyCharge; 
            set => _hourlyCharge = value;
        }

        public double HoursParked 
        { 
            get => _hoursParked;
            set
            {/*
                if (_hoursParked <= 0)
                {
                    throw new Exception("The hours must be greater than 0");
                }
                else if (_hoursParked > 24)
                {
                    ParkingException exp = new();
                    throw exp;
                }
                else
                {
                    _hoursParked = Math.Ceiling(value);
                }
                */
                _hoursParked = Math.Ceiling(value);
            }
        }

        public virtual double TotalCost 
        { 
            get => _totalCost = _hourlyCharge * _hoursParked;
        }

        public bool IsTowedAway
        {
            get => _isTowedAway;
            set
            {
                if (_hoursParked > 24) _isTowedAway = true;
                else _isTowedAway = false;
            }

        }
        public abstract void DisplayInfo();
        
        public void DisplayTotalCost()
        {
            if(HoursParked > 24)
            {
                throw new ParkingException();
            }

            
            Console.WriteLine("The total cost is {0}", TotalCost);           
            Console.WriteLine("---------------------------------------------------");
        }
    }
}