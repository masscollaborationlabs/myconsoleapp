using System;

class TemperatureConverter
{
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = FahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit}°F is equivalent to {celsius}°C.");
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
