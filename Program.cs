using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double fruitWeight = double.Parse(Console.ReadLine());
            bool isValid = true;
            double fruitPrice = 0;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": fruitPrice = 2.7; break;
                    case "apple": fruitPrice = 1.25; break;
                    case "orange": fruitPrice = 0.9; break;
                    case "grapefruit": fruitPrice = 1.6; break;
                    case "kiwi": fruitPrice = 3.0; break;
                    case "pineapple": fruitPrice = 5.60; break;
                    case "grapes": fruitPrice = 4.20; break;
                    default: isValid = false; break;
                }
            }
            else if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana": fruitPrice = 2.5; break;
                    case "apple": fruitPrice = 1.20; break;
                    case "orange": fruitPrice = 0.85; break;
                    case "grapefruit": fruitPrice = 1.45; break;
                    case "kiwi": fruitPrice = 2.70; break;
                    case "pineapple": fruitPrice = 5.50; break;
                    case "grapes": fruitPrice = 3.85; break;
                    default: isValid = false; break;
                }
            }
            else
            {
                isValid = false;
            }
            if (isValid == false)
            {
                Console.WriteLine("error");
            }
            else
            {
                double sum = fruitWeight * fruitPrice;
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}

