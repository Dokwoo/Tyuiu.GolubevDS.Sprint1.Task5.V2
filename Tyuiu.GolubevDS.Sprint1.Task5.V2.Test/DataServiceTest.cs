using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GolubevDS.Sprint1.Task5.V2.Lib;
namespace Tyuiu.GolubevDS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 50;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(x);

            int result = Convert.ToInt32(res);

            int wait = 10;
            Assert.AreEqual(wait, result);
        }
    }
}
