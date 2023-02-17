namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fTemp = 70.0;
            double cTemp = 20.0;

            Console.WriteLine("Converting fahrenheit to celsius");
            Console.WriteLine(TempConverter.FahrenhietToCelsius(fTemp));

            Console.WriteLine("Converting celsius to fahrenheit");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(cTemp));


        }
    }
}
