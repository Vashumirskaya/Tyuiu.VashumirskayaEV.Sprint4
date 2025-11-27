using Tyuiu.VashumirskayaEV.Sprint4.Task1.V9.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };

            int result = ds.Calculate(array);

            Assert.AreEqual(4032, result);
        }
    }
}
