using Tyuiu.VashumirskayaEV.Sprint4.Task2.V4.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Подсчёт суммы нечётных элементов массива                          *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит сумму нечётных элементов массива.  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 6, 3, 7, 7, 7, 3, 3, 6, 4, 8, 9, 1, 5 };

            Console.WriteLine("Массив: 6, 3, 7, 7, 7, 3, 3, 6, 4, 8, 9, 1, 5");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Сумма нечётных элементов массива: {result}");

            Console.ReadKey();
        }
    }
}
