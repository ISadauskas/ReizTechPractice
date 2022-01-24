using System;

namespace ReizTech_Ex1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please imput the hours: ");
            int hours = int.Parse(Console.ReadLine());
            while(hours < 0 || hours > 12)
            {
                Console.WriteLine("Please imput a valid number of hours: ");
                hours = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please imput the minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            while (minutes < 0 || minutes > 59)
            {
                Console.WriteLine("Please imput a valid number of minutes: ");
                minutes = int.Parse(Console.ReadLine());
            }

            decimal minuteDegree = (360 / 60) * minutes;
            decimal minutePercentage = (minuteDegree / 360m);
            decimal hourDegree = (((360 / 12) * hours) + (30 * minutePercentage));
                
            decimal degree = Math.Round(Math.Abs(minuteDegree - hourDegree));
            Console.WriteLine(degree);
        }
    }
}
