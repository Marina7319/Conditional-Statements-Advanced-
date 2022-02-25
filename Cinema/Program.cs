using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //четем от конзолата
                string ticketType = Console.ReadLine();
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                //изчисляваме броя на местата в залатa
                double income = row * col;

                //проверяваме типа на билетите и изчисляваме приходите от билетите
                if (ticketType == "Premiere")
                {
                    income = income * 12.00;
                }
                else if (ticketType == "Normal")
                {
                    income = income * 7.50;
                }
                else
                {
                    income = income * 5.00;
                }

                //извеждаме резултат
                Console.WriteLine("{0:f2} leva", income);

            }
        }
    }
}

