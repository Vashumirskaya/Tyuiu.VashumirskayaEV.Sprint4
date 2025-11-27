using Tyuiu.VashumirskayaEV.Sprint4.Task0.V11.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Поиск произведения нечётных элементов массива                      *");
            Console.WriteLine("* Задание #11                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит произведение всех нечётных        *");
            Console.WriteLine("* элементов массива.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };

            Console.WriteLine("Массив: 8, 9, 5, 4, 3, 2, 1, 0, 5, 7");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetMultOddArrEl(array);
            Console.WriteLine($"Произведение нечётных элементов массива: {result}");

            Console.ReadKey();
        }
    }
}
