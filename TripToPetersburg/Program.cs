using System;
using System.Collections.Generic;
using System.Linq;

namespace TripToPetersburg
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Быстрое решение. Проверяем Отношение важности к затраченному времени. 
            const double availableTime = 32;
            List<Sights> sights = SightsData.GetSights();

            var sortedSights = sights.OrderBy(u => u.Importance / u.Time)
                                     .ToList();

            List<Sights> selectedSights = new List<Sights>();
            double totalTime = 0;
            int totalImportance = 0;

            foreach (var sight in sortedSights)
            {
                if (totalTime + sight.Time <= availableTime)
                {
                    selectedSights.Add(sight);
                    totalTime += sight.Time;
                    totalImportance += sight.Importance;
                    Console.WriteLine($"Посещаем {sight.Name} - {sight.Time} ч, Важность: {sight.Importance}");
                }
            }
            Console.WriteLine($"Общее время: {totalTime} ч, Общая важность: {totalImportance}");
        }
    }

}
