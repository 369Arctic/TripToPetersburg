# Оптимальный маршрут осмотра достопримечательностей в Санкт-Петербурге

## Описание задачи

Вы приехали в Санкт-Петербург на двое суток (48 часов) и хотите осмотреть все главные достопримечательности, но ваше время ограничено. Кроме того, вам необходимо дважды поспать по 8 часов. Для перекусов время не выделяется, так как вы перекусываете на ходу. Вы составили список достопримечательностей с указанием времени, необходимого для их посещения, и их важности.

Необходимо написать программу, которая вычислит оптимальный маршрут осмотра достопримечательностей, исходя из их важности и ограниченного времени.

## Входные данные

Список достопримечательностей с указанием времени на их посещение и их важности.

| Название достопримечательности                            | Время на посещение | Важность |
|-----------------------------------------------------------|-------------------|----------|
| Исаакиевский собор                                         | 5 ч               | 10       |
| Эрмитаж                                                   | 8 ч               | 11       |
| Кунсткамера                                               | 3,5 ч             | 4        |
| Петропавловская крепость                                  | 10 ч              | 7        |
| Ленинградский зоопарк                                      | 9 ч               | 15       |
| Медный всадник                                            | 1 ч               | 17       |
| Казанский собор                                           | 4 ч               | 3        |
| Спас на Крови                                             | 2 ч               | 9        |
| Зимний дворец Петра I                                     | 7 ч               | 12       |
| Зоологический музей                                       | 5,5 ч             | 6        |
| Музей обороны и блокады Ленинграда                        | 2 ч               | 19       |
| Русский музей                                             | 5 ч               | 8        |
| Навестить друзей                                          | 12 ч              | 20       |
| Музей восковых фигур                                      | 2 ч               | 13       |
| Литературно-мемориальный музей Ф.М. Достоевского          | 4 ч               | 2        |
| Екатерининский дворец                                     | 1,5 ч             | 5        |
| Петербургский музей кукол                                 | 1 ч               | 14       |
| Музей микроминиатюры «Русский Левша»                      | 3 ч               | 18       |
| Всероссийский музей А.С. Пушкина и филиалы                | 6 ч               | 1        |
| Музей современного искусства Эрарта                       | 7 ч               | 16       |

## Задача

Написать программу для вычисления оптимального маршрута осмотра достопримечательностей, который позволяет посетить самые важные из них, не превышая доступного времени в 32 часа (с учётом двух периодов сна по 8 часов).

## Пример использования программы

1. Ввод: список достопримечательностей с указанием времени на посещение и важности.
2. Программа вычисляет маршрут, который максимально учитывает важность достопримечательностей и не превышает доступного времени.
3. Вывод: оптимальный маршрут, включая список достопримечательностей, общее время на их посещение и суммарную важность маршрута.
