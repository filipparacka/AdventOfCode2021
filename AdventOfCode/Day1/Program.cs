using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var day1 = new Day1();

            var input = day1.ReadInput("input.txt");

            var result = day1.GetNumberOfMeasurments(input);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public class Day1
    {
        public List<string> ReadInput(string path)
        {
            return File.ReadAllLines(path).ToList();
        }

        public int GetNumberOfMeasurments(List<string> input)
        {
            var values = input.Select(int.Parse).ToList();

            int result = values.Skip(3)
            .Select((x, i) => x > values[i])
            .Count(y => y);

            return result;
        }
    }

}
