using Tyuiu.VashumirskayaEV.Sprint4.Task2.V4.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 6, 3, 7, 7, 7, 3, 3, 6, 4, 8, 9, 1, 5 }; 

            int result = ds.Calculate(array);

            Assert.AreEqual(35, result);
        }
    }
}
