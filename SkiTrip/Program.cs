using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        { 
            int deysStay = int.Parse(Console.ReadLine()) - 1;
            string room = Console.ReadLine();
            string discount = Console.ReadLine();
            double stayPrice = 0.0;
            double sum = 0.0;
            double total = 0.0;
            switch (room)
            {
                case "room for one person":
                    if (deysStay < 10)
                    {
                        stayPrice = deysStay * 18;
                    }
                    else if (deysStay >= 10 && deysStay < 15)
                    {
                        stayPrice = deysStay * 18;
                    }
                    else
                    {
                        stayPrice = deysStay * 18;
                    }
                    break;
                case "apartment":
                    if (deysStay < 10)
                    {
                        stayPrice = deysStay * 25 - deysStay * 25 * 0.3;
                    }
                    else if (deysStay >= 10 && deysStay < 15)
                    {
                        stayPrice = deysStay * 25 - deysStay * 25 * 0.35;
                    }
                    else
                    {
                        stayPrice = deysStay * 25 - deysStay * 25 * 0.5;
                    }
                    break;
                case "president apartment":
                    if (deysStay < 10)
                    {
                        stayPrice = deysStay * 35 - deysStay * 35 * 0.1;
                    }
                    else if (deysStay >= 10 && deysStay < 15)
                    {
                        stayPrice = deysStay * 35 - deysStay * 35 * 0.15;
                    }
                    else
                    {
                        stayPrice = deysStay * 35 - deysStay * 35 * 0.2;
                    }
                    break;
            }
            if (discount == "positive")
            {
                sum = stayPrice * 0.25;
                total = stayPrice + sum;
            }
            else if (discount == "negative")
            {
                sum = stayPrice * 0.1;
                total = stayPrice - sum;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
