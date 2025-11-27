using Tyuiu.VashumirskayaEV.Sprint4.Task4.V26.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task4.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Замена нечётных элементов двумерного массива на 0                   *");
            Console.WriteLine("* Задание #26                                                             *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая заменяет нечётные элементы двумерного массива*");
            Console.WriteLine("* на 0.                                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix =
            {
                { 5, 4, 1, 1, 2 },
                { 3, 2, 4, 3, 5 },
                { 5, 2, 3, 2, 2 },
                { 2, 5, 1, 1, 4 },
                { 5, 3, 4, 3, 2 }
            };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            int[,] resultMatrix = ds.Calculate(matrix);

            Console.WriteLine("Массив после замены нечётных элементов на 0:");
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
