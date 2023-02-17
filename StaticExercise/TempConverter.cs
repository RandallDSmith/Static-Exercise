using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenhietToCelsius(double temp)
        {
            return (temp - 32) * .5556;
        }

        public static double CelsiusToFahrenheit(double temp)
        {
            return (temp * 1.8) + 32;
        }

    }
}
