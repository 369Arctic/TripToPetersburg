using System;

namespace TripToPetersburg
{
    public class Program
    {
        static void Main(string[] args)
        {
            TripPlanner.FindOptimalRoute();
            Console.WriteLine("Конец расчета по первому алгоритму\n");

            TripPlanner2.FindOptimalRoute2();
            Console.WriteLine("Конец расчета по второму алгоритму\n");
        }
    }

}
