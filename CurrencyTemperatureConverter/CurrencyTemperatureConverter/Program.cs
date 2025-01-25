using System;

namespace CurrencyTemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What converter you want to use? Currency(c)\nTemperature(t)?");
            string choice=Console.ReadLine();

            if (choice == "c")
            {
                Console.WriteLine("Enter the currency you want to change dollar to pound(p)\npound to dollar(d)");
                string currencyChoice = Console.ReadLine();
                if (currencyChoice == "p")
                {
                    Console.WriteLine("Enter the amount you want to convert");
                    int dollarAmount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Amount in pound{dollarAmount * 0.8}");
                }
                else if (currencyChoice == "d")
                {
                    Console.WriteLine("Enter the amount you want to convert");
                    int poundAmount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Amount in dollars{poundAmount * 1.25}");
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }
            }
            else if (choice == "t")
            {

                Console.WriteLine("Enter the measure you want to change celsius to fahrenheit(f)\n fahrenheit to celsius(c) ");
                string temperatureChoice = Console.ReadLine();
                if (temperatureChoice == "f")
                {
                    Console.WriteLine("Enter celsius value ");
                    int celsiusAmount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"fahrenheit{ (celsiusAmount*9/5)+ 32}");
                }
                else if (temperatureChoice == "c")
                {
                    Console.WriteLine("Enter the fahrenheit value ");
                    int fahrenheitAmount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{(fahrenheitAmount-32)*5/9}");
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }
            }
        }
    }
}