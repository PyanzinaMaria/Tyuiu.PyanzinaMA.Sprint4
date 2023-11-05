using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PyanzinaMA.Sprint4.Task1.V10.Lib;

namespace Tyuiu.PyanzinaMA.Sprint4.Task1.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Пьянзина М. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Пьянзина Мария Алексеевна | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива.С клавиатуры: 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int len = 11;
            int[] Array = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива:");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив = ");
            
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + ", ");
            }

            Console.WriteLine($"произведение нечетных элементов = {ds.Calculate(Array)}");
            Console.ReadKey();
        }
    }
}
