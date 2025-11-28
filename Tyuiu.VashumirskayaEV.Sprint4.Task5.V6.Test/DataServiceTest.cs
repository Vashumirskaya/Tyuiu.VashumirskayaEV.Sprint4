using Tyuiu.VashumirskayaEV.Sprint4.Task5.V6.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { -3,  0,  2,  5, -1 },
                {  1, -2,  3,  0,  4 },
                { -1, -3,  0,  5,  2 },
                {  0,  1, -2, -3,  4 },
                {  5, -1,  2,  0, -3 }
            };

            int[,] expected =
            {
                { -3,  0,  1,  1, -1 },
                {  1, -2,  1,  0,  1 },
                { -1, -3,  0,  1,  1 },
                {  0,  1, -2, -3,  1 },
                {  1, -1,  1,  0, -3 }
            };

            int[,] actual = ds.Calculate(matrix);

            int rows = expected.GetLength(0);
            int cols = expected.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
    }
}
