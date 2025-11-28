using Tyuiu.VashumirskayaEV.Sprint4.Task6.V30.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint4.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] data = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            string[] expected = { "Береза" };

            string[] actual = ds.Calculate(data);

            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
