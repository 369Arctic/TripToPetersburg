using System;
using System.Collections.Generic;
using System.Linq;

namespace TripToPetersburg
{
    public class TripPlanner
    {
        private const double availableTime = 32;
        public static void FindOptimalRoute()
        {
            
            List<Sights> sights = SightsData.GetSights();

            // Сортируем список по отношению важность/время. Чем выше отношение - тем приоритетней достопримечательность. 
            var sortedSights = sights.OrderBy(u => u.Importance / u.Time)
                                     .ToList();

            // Список для хранения достопримечательностей, которые мы выберем
            List<Sights> selectedSights = new List<Sights>();

            // Переменные для хранения общего времени и важности
            double totalTime = 0;
            int totalImportance = 0;

            // Проходимся по отсортированному списку, если есть свободное время - добовляем достопримечательность в маршрут.
            foreach (var sight in sortedSights)
            {
                if (totalTime + sight.Time <= availableTime)
                {
                    selectedSights.Add(sight);
                    totalTime += sight.Time;
                    totalImportance += sight.Importance;
                    Console.WriteLine($"Посещаем {sight.Name} - {sight.Time} ч., Важность: {sight.Importance}");
                }
            }
            Console.WriteLine($"Общее время: {totalTime}, Общая важность: {totalImportance}");
        }
    }
}
