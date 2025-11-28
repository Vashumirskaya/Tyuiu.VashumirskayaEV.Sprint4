using Tyuiu.VashumirskayaEV.Sprint4.Task7.V8.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 3, m = 4;
            string value = "264795863157";
            int expected = 37;

            int actual = ds.Calculate(n, m, value);

            Assert.AreEqual(expected, actual);
        }
    }
}
