using ParkingSystem;
using ParkingSystemClassLibrary;

NonStaff nonStaff = new(2); // create a nonstaff object with hourly charge of $2
Staff staff = new(2, 2, 10); // create a staff object with hourly charge, base fee, base hours

// nonstaff parking 
string input1 = Console.ReadLine();
double hoursParked1;
while(!Double.TryParse(input1, out hoursParked1) || hoursParked1 < 0)
{
    Console.WriteLine("Please enter a positive number");
    input1 = Console.ReadLine();
}

nonStaff.HoursParked = hoursParked1;
nonStaff.DisplayInfo();
try
{
    nonStaff.DisplayTotalCost();
}
catch (ParkingException ex)
{
    Console.WriteLine(ex.Message);
}


// staff parking
string input2 = Console.ReadLine();
double hoursParked2;
while (!Double.TryParse(input2, out hoursParked2) || hoursParked2 < 0)
{
    Console.WriteLine("Please enter a positive number");
    input2 = Console.ReadLine();
}
staff.HoursParked = hoursParked2;

staff.DisplayInfo();
try
{
    staff.DisplayTotalCost();
}
catch (ParkingException ex)
{
    Console.WriteLine(ex.Message);
}