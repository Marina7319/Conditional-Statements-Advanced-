using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine(); //Tulips
            int numberFlowers = int.Parse(Console.ReadLine());//88
            int budget = int.Parse(Console.ReadLine());//260
            int roses = 5;//5
            double dahlias = 3.8;//3.80
            double tulips = 2.8;//2.5
            double narcissus = 3;//2.8
            double gladiolus = 2.5;//2.5
            double totalPrice = 0;
            switch (flowers)
            {
                case "Roses":
                    if (numberFlowers > 80)
                    {
                        Double total = numberFlowers * roses - (numberFlowers * roses) * 0.1;
                        totalPrice = total;
                    }
                    else
                    {
                        Double total = numberFlowers * roses;//275
                        totalPrice = total;//275
                    }
                    break;
                case "Dahlias":
                    if (numberFlowers > 90)
                    {
                        Double total = numberFlowers * dahlias - (numberFlowers * dahlias) * 0.15;
                        totalPrice = total;
                    }
                    else
                    {
                        Double total = numberFlowers * dahlias;
                        totalPrice = total;
                    }
                    break;
                case "Narcissus":
                    if (numberFlowers < 120)
                    {
                        Double total = numberFlowers * narcissus + (numberFlowers * narcissus) * 0.15;
                        totalPrice = total;
                    }
                    else
                    {
                        Double total = numberFlowers * narcissus;
                        totalPrice = total;
                    }
                    break;
                case "Gladiolus":
                    if (numberFlowers < 80)
                    {
                        Double total = numberFlowers * gladiolus + (numberFlowers * gladiolus) * 0.2;
                        totalPrice = total;
                    }
                    else
                    {
                        Double total = numberFlowers * gladiolus;
                        totalPrice = total;
                    }
                    break;
                case "Tulips":
                    if (numberFlowers > 80)
                    {
                        Double total = numberFlowers * tulips - (numberFlowers * tulips) * 0.15;
                        totalPrice = total;
                    }
                    else
                    {
                        Double total = numberFlowers * tulips;
                        totalPrice = total;
                    }
                    break;
            }
            if (totalPrice <= budget)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyLess = totalPrice - budget;//275-220=55
                Console.WriteLine($"Not enough money, you need {moneyLess:f2} leva more.");
            }
        }
    }
}
