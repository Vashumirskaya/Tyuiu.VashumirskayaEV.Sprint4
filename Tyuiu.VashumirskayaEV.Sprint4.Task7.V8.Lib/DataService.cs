using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task7.V8.Lib
{
    public class DataService : ISprint4Task7V8
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0;
            int index = 0;        

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int digit = value[index] - '0';   
                    index++;

                    if (digit % 2 == 1)            
                        sum += digit;
                }
            }

            return sum;
        }
    }
}
