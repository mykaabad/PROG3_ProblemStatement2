using System;

namespace ProblemStatement2 { }
    class Program
{ 
    static void Main(string[] args)
    {

        //determine if the employee is late or not.

        Console.WriteLine("Employee Time Keeping");
        Console.WriteLine($"Today's Date: {DateTime.Today.ToShortDateString()}");

        Console.Write("To time-in, please insert your Employee I.D: ");
        string employeeId = Console.ReadLine();

        TimeSpan timeIn = new TimeSpan(8, 0, 0);
        Console.WriteLine($"Your time-in time is recorded successfully. {timeIn}");

        Console.WriteLine("-------------------------------------");
        Console.Write("To time-out, please enter your Employee I.D: ");
        employeeId = Console.ReadLine();

        TimeSpan timeOut = new TimeSpan(17, 0, 0);
        Console.WriteLine($"Your time-out time is recorded successfully. {timeOut}");

        TimeSpan lunchBreak = new TimeSpan(1, 0, 0);
        TimeSpan totalworkHours = (timeOut + timeIn) - lunchBreak;
        
        
        Console.WriteLine("-------------------------------------");
        Console.Write($"Your total work hour is: {totalworkHours}");

        TimeSpan regularHourStart = new TimeSpan(8, 0, 0);
        TimeSpan regularHourEnd = new TimeSpan(17, 0, 0);
        TimeSpan lateIn = new TimeSpan(0, 0, 0);
        TimeSpan earlyOut = new TimeSpan(0, 0, 0);
        TimeSpan lateTime = new TimeSpan(0, 30, 0);
        

        if (timeIn > regularHourStart)
        {
            lateIn = timeIn - regularHourStart;
        }
      

        if (timeOut < regularHourEnd)
        {
            earlyOut = timeOut - regularHourEnd;
        }

        TimeSpan totalRegularHours = totalworkHours - (lateIn - earlyOut);

        Console.WriteLine($"Your total regular hours worked is: {totalRegularHours}");
        Console.WriteLine($"Your amount of late time is: {lateTime}");


    }
}

