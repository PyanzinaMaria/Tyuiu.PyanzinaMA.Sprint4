using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PyanzinaMA.Sprint4.Task7.V16.Lib;

namespace Tyuiu.PyanzinaMA.Sprint4.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Пьянзина М. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Пьянзина Мария Алексеевна | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 382976421897948. Преобразуйте ее в    *");
            Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение четных чисел.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            //Дана строка из одноразрядных цифр "382976421897948". Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.

            string value = "382976421897948";
            
            int[,] mtrx = new int[5, 3];
            
            int n = 5;
            int m = 3;
            
            Console.WriteLine("Входная строка: " + value);
            Console.WriteLine("Матрица: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                    Console.Write(mtrx[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение чётных элементов массива: " + ds.Calculate(n, m, value));

            Console.ReadKey();
        }
    }
}
