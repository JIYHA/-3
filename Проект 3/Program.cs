using System;

namespace Проект_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Определение угла");
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Minutes: ");
                int min = int.Parse(Console.ReadLine());
                Console.Write("Seconds: ");
                int sec = int.Parse(Console.ReadLine());
                double angle = hours * 30 + min / 2 + sec / 120;
                Console.WriteLine(angle);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
