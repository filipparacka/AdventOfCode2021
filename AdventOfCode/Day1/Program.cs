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

            int result = 0;
            int sum = values[0] + values[1] + values[2];

            for (int i = 1; i < values.Count() - 2; i++)
            {
                var value = values[i] + values[i + 1] + values[i + 2];

                if (value > sum)
                {
                    result++;
                }

                sum = value;
            }

            return result;
        }
    }

}
