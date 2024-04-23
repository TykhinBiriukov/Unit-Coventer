using System;

class UnitConventor
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Unit Conventor!");
        Boolean work = true;
        while (work == true)
        {
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("1. Miles to Kilometers");
            Console.WriteLine("2. Pounds to Kilograms");
            Console.WriteLine("3. Fahrenheit to Celsius");
            Console.WriteLine("4. Quit the program");
            String input = Console.ReadLine();

            if (input == "1")
            {
                MiToKm();
            }
            else if (input == "2")
            {
                LbToKg();
            }
            else if (input == "3")
            {
                FtoC();
            }
            else if (input == "4")
            {
                work = false;
            }
            else
            {
                Console.WriteLine("Invalid number. Please try again.");
            }
        }
    }

    static void MiToKm()
    {
        Console.WriteLine("Please enter number of miles: ");
        double miles = double.Parse(Console.ReadLine());
        double kilometers = miles * 1.609344;
        Console.WriteLine("{0} miles is equal to {1} kilometers.",miles,kilometers);
    }

    static void LbToKg()
    {
        Console.WriteLine("Please enter number of pounds: ");
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds * 0.45359237;
        Console.WriteLine("{0} miles is equal to {1} kilograms.",pounds,kilograms);
    }

    static void FtoC()
    {
        Console.WriteLine("Please enter number of fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("{0} miles is equal to {1} celsius.",fahrenheit,celsius);
    }
}