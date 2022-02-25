using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();//May
            int stay = int.Parse(Console.ReadLine());//15
            double disscountStudio = 0;
            double disscountApartment = 0;
            switch (month)
            {
                case "May":
                case "October":
                    if (stay > 7 && stay <= 14)
                    {
                        disscountStudio = 50 - 50 * 0.05;
                    }
                    else  if (stay > 14)
                    {
 
                        disscountStudio = 50 - 50 * 0.3;//750-15
                    }
                    else if(stay <= 7)
                    {
                        disscountStudio = 50;
                    }
                    if (stay > 14)
                    {
                        disscountApartment = 65 - 65*0.1;//955-955x0.1=955-95.5=859.5
                    }
                    else
                    {
                        disscountApartment = 65;
                    }
                    break;
                case "June":
                case "September":
                    if (stay > 14)
                    {
                        disscountStudio = 75.20 - 75.20 * 0.2;
                    }
                    else
                    {
                        disscountStudio = 75.20;
                    }
                    if (stay > 14)
                    {
                        disscountApartment = 68.70 - 68.70*0.1;
                    }
                    else
                    {
                        disscountApartment = 68.70;
                    }
                    break;
                case "July":
                case "August":
                    disscountStudio = 76;
                    if (stay > 14)
                    {
                        disscountApartment = 77 - 77*0.1;
                    }
                    else
                    {
                        disscountApartment = 77; ;
                    }
                    break;
            }
            double sumStudio = disscountStudio * stay;
            double  sumApartment = disscountApartment * stay;
            Console.WriteLine($"Apartment: {sumApartment:f2} lv.");
            Console.WriteLine($"Studio: {sumStudio:F2} lv.");
        }
    }
}
