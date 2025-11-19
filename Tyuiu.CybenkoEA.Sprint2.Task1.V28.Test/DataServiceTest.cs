using Tyuiu.CybenkoEA.Sprint2.Task1.V28.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.CybenkoEA.Sprint2.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;

            bool[] wait = new bool[6] { true, false, true, false, true, false };
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}