//Есть два типа циклов.

//Первый - это циклы, контролируемые при входе. В подобном случае, условие подлежащее проверке, стоит в начале тела цикла. Такими циклами являются while и for.
//Цикл while. В начале цикла стоит условие при достижении которого, цикл заканчивает работу.

using System;

class whileLoop
{
    public static void Main()
    {
        int x = 1;

        // Выход из цикла при х > 4

        while (x <= 4)
        {
            Console.WriteLine("Myrusakov");

            // Увеличение значения переменной x на 1
            // операция инкремент
            x++;
        }
    }
}


// вывод
//Myrusakov
//Myrusakov
//Myrusakov
//Myrusakov


Цикл будет работать до тех пор пока условие в нем истинно.

//Цикл for.

Является родственным циклу while, но применяется при заранее известном условии. Это может быть повторение числа, строки, символов n-количество раз.

// C# program to illustrate for loop.
using System;

class forLoopDemo
{
    public static void Main()
    {

        for (int x = 1; x <= 4; x++)
            Console.WriteLine("Myrusakov");
    }
}

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

      if (number<0)
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