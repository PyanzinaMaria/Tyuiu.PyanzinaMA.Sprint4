using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PyanzinaMA.Sprint4.Task6.V13.Lib;

namespace Tyuiu.PyanzinaMA.Sprint4.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #4 | Выполнила: Пьянзина М. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Пьянзина Мария Алексеевна | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных Ford, Toyota, Honda, Chevrolet, Mercedes,   *");
            Console.WriteLine("* BMW, Audi используя класс Array подсчитайте количество элементов,       *");
            Console.WriteLine("* длина которых больше 4.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            //Дан строковый массив данных ["Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi"]
            //используя класс Array подсчитайте количество элементов, длина которых больше 4.
            
            string[] cars = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(cars);

            Console.WriteLine("Количество элементов с длиной больше 4: " + res);

            Console.ReadKey();
        }
    }
}
