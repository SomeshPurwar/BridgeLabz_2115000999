public class UnitConverter2
{
	public static void print(){
		Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsiusFromFahrenheit = ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit} °F = {celsiusFromFahrenheit} °C");

        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheitFromCelsius = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius} °C = {fahrenheitFromCelsius} °F");

        Console.Write("Enter weight in Pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilogramsFromPounds = ConvertPoundsToKilograms(pounds);
        Console.WriteLine($"{pounds} lbs = {kilogramsFromPounds} kg");

        Console.Write("Enter weight in Kilograms: ");
        double kilograms = Convert.ToDouble(Console.ReadLine());
        double poundsFromKilograms = ConvertKilogramsToPounds(kilograms);
        Console.WriteLine($"{kilograms} kg = {poundsFromKilograms} lbs");

        Console.Write("Enter volume in Gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        double litersFromGallons = ConvertGallonsToLiters(gallons);
        Console.WriteLine($"{gallons} gallons = {litersFromGallons} liters");

        Console.Write("Enter volume in Liters: ");
        double liters = Convert.ToDouble(Console.ReadLine());
        double gallonsFromLiters = ConvertLitersToGallons(liters);
        Console.WriteLine($"{liters} liters = {gallonsFromLiters} gallons");
	}
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        return pounds * 0.453592;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        return kilograms * 2.20462;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        return gallons * 3.78541;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        return liters * 0.264172;
    }
}
