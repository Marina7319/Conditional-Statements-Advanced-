using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());//50
            string season = Console.ReadLine();//summer
            double price = 0;
            string destination = "";
            string holiday = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    holiday = "Camp";
                    price = budget - budget * 0.7;//50-50x0.7=50-35=1575
                }
                else if (season == "winter")
                {
                    holiday = "Hotel";
                    price = budget - budget * 0.3;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    holiday = "Camp";
                    price = budget - budget * 0.6;
                }
                else if (season == "winter")
                {
                    holiday = "Hotel";
                    price = budget - budget * 0.2;
                }
            }
            else if (budget >= 1000)
            {
                destination = "Europe";
                holiday = "Hotel";
                price = budget - budget * 0.1;
            }        
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holiday} - {price:f2}");
        }
    }
}
