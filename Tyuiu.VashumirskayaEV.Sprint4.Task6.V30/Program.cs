using Tyuiu.VashumirskayaEV.Sprint4.Task6.V30.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task6.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (строковые)                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #XX                                                             *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив [\"Береза\", \"Дуб\", \"Клён\", \"Сосна\", \"Пихта\",      *");
            Console.WriteLine("* \"Осина\"]. Используя класс Array, вывести элементы, длина которых       *");
            Console.WriteLine("* больше 5 символов.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            string[] trees = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            Console.WriteLine("Исходный массив:");
            foreach (string t in trees)
            {
                Console.Write($"{t}  ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            string[] result = ds.Calculate(trees);

            Console.WriteLine("Элементы, длина которых больше 5 символов:");
            foreach (string t in result)
            {
                Console.WriteLine(t);
            }

            Console.ReadKey();
        }
    }
}
