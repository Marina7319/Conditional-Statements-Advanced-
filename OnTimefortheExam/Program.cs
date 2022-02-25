using System;

namespace OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeHourExam = int.Parse(Console.ReadLine());//9
            int timeMinutesExam = int.Parse(Console.ReadLine());//30
            int timeHourArrived = int.Parse(Console.ReadLine());//9
            int timeMinutesArrived = int.Parse(Console.ReadLine());//50
            //четем от конзолата четери цели числа час и минути за начало на изпита и час и минути на престигане
            timeMinutesExam = timeMinutesExam + timeHourExam * 60;//60x9+30=540+30=570
            timeMinutesArrived = timeMinutesArrived + timeHourArrived * 60;//60x9+50=540+50=590
            int difference = Math.Abs(timeMinutesArrived - timeMinutesExam);
            int hours = difference / 60;
            int minutes = difference % 60;
            //изчисляваме колко минути преди началото на изпита е престигнал или колко е закъснял за изпита
            if (timeMinutesExam < timeMinutesArrived)
            {
                Console.WriteLine("Late");

                if (hours >= 1)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
            else if (timeMinutesExam - timeMinutesArrived <= 30)
            {
                Console.WriteLine("On Time");

                if (timeMinutesExam != timeMinutesArrived)
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");

                if (hours >= 1)
                {
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
        }
    }
}
