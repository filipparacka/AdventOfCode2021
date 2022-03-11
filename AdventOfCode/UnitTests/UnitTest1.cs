using Day2;
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

        [TestMethod]
        public void Day2Test()
        {
            var day2 = new Day2.Day2();

            var commands = new List<Command>();

            commands.Add(new Command()
            {
                Position = "forward",
                Value = 5
            });

            commands.Add(new Command()
            {
                Position = "down",
                Value = 5
            });

            commands.Add(new Command()
            {
                Position = "forward",
                Value = 8
            });

            commands.Add(new Command()
            {
                Position = "up",
                Value = 3
            });

            commands.Add(new Command()
            {
                Position = "down",
                Value = 8
            });

            commands.Add(new Command()
            {
                Position = "forward",
                Value = 2
            });

            var result1 = day2.CalculateDive(commands);
            var result2 = day2.CalculateChangedDive(commands);

            Assert.AreEqual(150, result1);
            Assert.AreEqual(900, result2);
        }
    }
}
