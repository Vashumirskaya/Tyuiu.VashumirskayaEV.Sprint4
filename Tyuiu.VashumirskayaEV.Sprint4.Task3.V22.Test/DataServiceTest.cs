using Tyuiu.VashumirskayaEV.Sprint4.Task3.V22.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array =
            {
                { 4, 4, 7, 8, 9 },
                { 9, 5, 9, 7, 8 },
                { 7, 4, 9, 4, 6 },
                { 4, 4, 7, 4, 4 },
                { 4, 5, 8, 6, 7 }
            };

            int result = ds.Calculate(array);

            Assert.AreEqual(9, result);
        }
    }
}
