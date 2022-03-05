using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetNumberOfMeasurments_ShouldReturnCorrectResult()
        {
            var day1 = new Day1.Day1();

            var input = new List<string>()
            {
                "199",
                "200",
                "208",
                "210",
                "200",
                "207",
                "240",
                "269",
                "260",
                "263"
            };

            var result = day1.GetNumberOfMeasurments(input);

            Assert.AreEqual(5,result);
        }
    }
}
