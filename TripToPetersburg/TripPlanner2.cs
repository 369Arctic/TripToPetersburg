using System;
using System.Collections.Generic;

namespace TripToPetersburg
{
    public class TripPlanner2
    {
        private const double availableTime = 32;

        public static void FindOptimalRoute2()
        {
            List<Sights> sights = SightsData.GetSights();

            // Преобразуем время в целые значения (для удобства работы с массивами)
            int maxTimeInt = (int)(availableTime * 2);

            // Массив для хранения максимального приоритета для каждого времени
            int[] dp = new int[maxTimeInt + 1];

            // Создаем массив для хранения выбранных достопримечательностей для каждого времени
            List<Sights>[] selectedSights = new List<Sights>[maxTimeInt + 1];
            for (int i = 0; i <= maxTimeInt; i++)
            {
                selectedSights[i] = new List<Sights>();
            }

            // Для каждой достопримечательности
            foreach (var sight in sights)
            {
                // Преобразуем время посещения в целое число
                int timeInt = (int)(sight.Time * 2);

                // Вычисляем приоритет
                int priority = GetPriority(sight);

                // Обновляем массив dp
                for (int t = maxTimeInt; t >= timeInt; t--)
                {
                    // Рассчитываем новый приоритет, если включаем текущую достопримечательность
                    int newPriority = dp[t - timeInt] + priority;

                    // Если новый приоритет выше текущего, обновляем значение в dp и список выбранных достопримечательностей
                    if (newPriority > dp[t])
                    {
                        dp[t] = newPriority;
                        selectedSights[t] = new List<Sights>(selectedSights[t - timeInt]) { sight };
                    }
                }
            }

            // Ищем максимальный приоритет и соответствующее время
            int maxPriority = 0;
            int bestTime = 0;
            for (int t = 0; t <= maxTimeInt; t++)
            {
                if (dp[t] > maxPriority)
                {
                    maxPriority = dp[t];
                    bestTime = t;
                }
            }

            // Вычисляем общее время и суммарную важность выбранных достопримечательностей
            double totalTime = 0;
            int totalImportance = 0;

            //Console.WriteLine($"Максимальный приоритет: {maxPriority}");
            Console.WriteLine("Посещаем достопримечательности:");

            foreach (var sight in selectedSights[bestTime])
            {
                totalTime += sight.Time; // Суммируем время
                totalImportance += sight.Importance; // Суммируем важность
                Console.WriteLine($"- {sight.Name} (Время: {sight.Time} ч, Важность: {sight.Importance})");
            }

            Console.WriteLine($"Общее время: {totalTime} ч.");
            Console.WriteLine($"Общая важность: {totalImportance}");
        }

        public static int GetPriority(Sights sight)
        {
            // Преобразуем важность в приоритет (меньшая важность - больший приоритет)
            return 21 - sight.Importance;
        }
    }
}
