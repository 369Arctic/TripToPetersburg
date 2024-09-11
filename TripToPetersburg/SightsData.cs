using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripToPetersburg
{
    public static class SightsData
    {
        public static List<Sights> GetSights()
        {
            return new List<Sights>()
            {
                new Sights("Исаакиевский собор", 5, 10),
                new Sights("Эрмитаж", 8, 11),
                new Sights("Кунсткамера", 3.5, 4),
                new Sights("Петропавловская крепость", 10, 7),
                new Sights("Ленинградский зоопарк", 9, 15),
                new Sights("Медный всадник", 1, 17),
                new Sights("Казанский собор", 4, 3),
                new Sights("Спас на Крови", 2, 9),
                new Sights("Зимний дворец Петра I", 7, 12),
                new Sights("Зоологический музей", 5.5, 6),
                new Sights("Музей обороны и блокады Ленинграда", 2, 19),
                new Sights("Русский музей", 5, 8),
                new Sights("Навестить друзей", 12, 20),
                new Sights("Музей восковых фигур", 2, 13),
                new Sights("Музей Достоевского", 4, 2),
                new Sights("Екатерининский дворец", 1.5, 5),
                new Sights("Петербургский музей кукол", 1, 14),
                new Sights("Музей микроминиатюры \"Русский Левша\"", 3, 18),
                new Sights("Музей Пушкина", 6, 1),
                new Sights("Музей Эрарта", 7, 16)
            };
        }
    }
}
