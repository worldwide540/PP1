using System;

class TemperatureConverter
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Main()
    {
        double celsiusTemperature = 25.0; // Температура в Цельсиях
        double fahrenheitTemperature = CelsiusToFahrenheit(celsiusTemperature);
        Console.WriteLine($"{celsiusTemperature} градусов Цельсия = {fahrenheitTemperature} градусов Фаренгейта");

        double newCelsiusTemperature = FahrenheitToCelsius(fahrenheitTemperature);
        Console.WriteLine($"{fahrenheitTemperature} градусов Фаренгейта = {newCelsiusTemperature} градусов Цельсия");
    }
}
