using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[0, i] > max)
                {
                    max = array[0, i];
                }
            }

            return max;
        }
    }
}
