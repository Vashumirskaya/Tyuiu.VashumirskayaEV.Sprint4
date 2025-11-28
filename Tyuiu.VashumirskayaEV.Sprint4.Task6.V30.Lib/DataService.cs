using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            string[] result = Array.FindAll(array, item => item.Length > 5);

            return result;
        }
    }
}
