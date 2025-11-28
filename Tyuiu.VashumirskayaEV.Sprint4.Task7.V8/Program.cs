using Tyuiu.VashumirskayaEV.Sprint4.Task7.V8.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #7и                                                             *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка \"264795863157\". Преобразовать в матрицу 3x4 и найти суммy *");
            Console.WriteLine("* нечетных элементов.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            int n = 3;
            int m = 4;
            string value = "264795863157";

            Console.WriteLine($"Строка: {value}");
            Console.WriteLine($"Размер матрицы: {n} x {m}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            int sumOdd = ds.Calculate(n, m, value);
            Console.WriteLine($"Сумма нечетных чисел = {sumOdd}");

            Console.ReadKey();
        }
    }
}
