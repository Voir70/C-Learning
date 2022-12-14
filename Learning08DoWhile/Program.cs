/*Если сравнивать оператор цикла do-while с оператором цикла while,
то легко заметить главное отличие этих операторов. Выполнение оператора
while начинается с проверки условия, и если условие истинно,
то выполняются команды в теле оператора цикла. В операторе цикла
do-while сначала выполняются команды в теле оператора, и только
после этого проверяется условие. Получается, что в операторе цикла
do-while команды из тела оператора будут выполнены по крайней
мере один раз. С оператором while дела обстоят иначе: если при первой
проверке условия оно окажется ложным, то команды в теле оператора
вообще выполняться не будут.
Как пример использования оператора цикла do-while мы рассмотрим
программу вычисления суммы нечетных чисел - то есть программу,
аналогичную той, что реализовалась с использованием оператора цикла
while.*/
// Количество слагаемых в сумме, индексная
// переменная и значение суммы:
int n=l0, k=l, s=0;
// Отображение сообщения:
Console.Write("Cyммa 1 + 3 + 5 + ... +{О}= ",2*n-1);
// Оператор цикла:
do{
s+=2*k-1; // Добавляем слагаемое в сумму
k++; // Новое значение индексной переменной
}while(k<=n);
// Отображение вычисленного значения:
Console.WriteLine(s);
//Результат выполнения программы точно такой же, как и для случая, когда
//использовался оператор цикла while.

//Второй тип это цикл do-while, и foreach. Тело цикла do-while будет выполнено по крайней мере один раз, независимо от условия цикла. Пример использования - определение количества цифр в натуральном числе.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определение количества цифр 7 в числе
            int number;
            int t;
            int k;

            // Ввод числа
            Console.Write("number = ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Error. Incorrect number.");
                Console.ReadKey();
                return;
            }

            // Вычисление
            t = number; // сделать копию из number
            k = 0;

            // цикл вычисления k
            do
            {
                if (t % 10 == 7) k++;
                t = t / 10;
            } while (t > 0);

            Console.WriteLine("k = {0}", k);
            Console.ReadKey();
        }
    }
}

Цикл foreach служит для циклического обращения к элементам коллекции - массива.