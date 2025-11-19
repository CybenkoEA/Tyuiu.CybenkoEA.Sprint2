using Tyuiu.CybenkoEA.Sprint2.Task3.V16.Lib;
namespace Tyuiu.CybenkoEA.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(128, res);
        }
    }
}
