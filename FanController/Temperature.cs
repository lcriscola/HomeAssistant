using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanController
{
    public static class Temperature
    {
        public static  string GetRaw()
        {
            var info = new System.Diagnostics.ProcessStartInfo("vcgencmd", "measure_temp");
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            var proc = System.Diagnostics.Process.Start(info);
            var output = proc.StandardOutput.ReadToEnd().Trim();
            proc.WaitForExit();

            var parts = output.Split('=');
            var temp = parts[1];


            return temp;
        }

        public static double GetCelsius()
        {
            string temp = GetRaw();
            var t = temp.Substring(0, temp.Length - 2);
            if (temp.EndsWith("C", StringComparison.OrdinalIgnoreCase))
                return double.Parse(t);
            if (temp.EndsWith("F", StringComparison.OrdinalIgnoreCase))
                return FahrenheitToCelsius(double.Parse(t));

            throw new ArgumentException($"{temp} couldn't be converted to Celsius");

        }
        public static double GetFahrenheit()
        {
            string temp = GetRaw();
            var t = temp.Substring(0, temp.Length - 2);

            if (temp.EndsWith("F", StringComparison.OrdinalIgnoreCase))
                return double.Parse(t);
            if (temp.EndsWith("C", StringComparison.OrdinalIgnoreCase))
                return CelsiusToFahrenheit(double.Parse(t));
            throw new ArgumentException($"{temp} couldn't be converted to Fahrenheit");
        }

        private static double CelsiusToFahrenheit(double value)
        {
            return ((value * 9) / 5) + 32;
        }
        private static double FahrenheitToCelsius(double value)
        {
            return (value- 32) * 5 / 9;
        }


    }
}
