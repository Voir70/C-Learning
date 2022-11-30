//Инструкция if-else 
//Иногда нам нужно выполнить различные действия в зависимости от некоторых условий. 
//В таком случае, как нельзя кстати, пригодится конструкция if-else, которая есть и в C#.
//Принципиально, данная конструкция в C# ничем не отличается от похожих в других языках. 
//Поэтому далее пример использования с комментариями:

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // полная версия со скобками
            int y = 233;
            if (y > 233) {
                Console.WriteLine("Переменная y больше 233");
            }
            else {
                Console.WriteLine("Переменная y меньше или равна 233");
            }

            // без скобок
            if (y > 233) Console.WriteLine("Переменная y больше 233");
            else Console.WriteLine("Переменная y меньше или равна 233");


            // промежуточная конструкция if-else может пристутствовать несколько раз
            if (y > 233) {
                Console.WriteLine("Переменная y больше 233");
            }
            else if (y == 233) {
                Console.WriteLine("Переменная y равна 233");
            }
            else {
                Console.WriteLine("Переменная y меньше 233");
            }

            // вывод тектса в консоль в зависимости от ввода пользователя
            Console.WriteLine("Введите 0, 1 или 2:");
            string input = Console.ReadLine();
            if (input == "0") {
                Console.WriteLine("Вы ввели ноль");
            }
            else if (input == "1") {
                Console.WriteLine("Вы ввели один");
            }
            else if (input == "2") {
                Console.WriteLine("Вы ввели два");
            }

            if (input != "1" && input != "2" && input != "3") {
                Console.WriteLine("Некорректный ввод");
            }
           
            // результат логического выражения помещаем в переменную
            bool condition = 12 < 7 && (true && (5 < 7));
            if (condition) Console.WriteLine("Условие истинно");

        }
    }
}