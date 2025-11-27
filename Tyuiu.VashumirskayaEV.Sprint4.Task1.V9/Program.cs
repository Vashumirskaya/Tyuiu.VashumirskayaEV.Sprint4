using Tyuiu.VashumirskayaEV.Sprint4.Task1.V9.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Поиск произведения четных элементов массива                        *");
            Console.WriteLine("* Задание #9                                                              *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит произведение всех четных элементов *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };

            Console.WriteLine("Массив: 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Произведение четных элементов массива: {result}");

            Console.ReadKey();
        }
    }
}
