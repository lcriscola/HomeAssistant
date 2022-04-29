using System;

namespace FanController
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"{Temperature.GetRaw()} {Temperature.GetCelsius():N2}°C {Temperature.GetFahrenheit():N2}°F");
                System.Threading.Thread.Sleep(1000);
            }
        }

      
    }
}
