using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var day2 = new Day2();

            var input = day2.ReadInput();

            var result1 = day2.CalculateDive(input);

            var result2 = day2.CalculateChangedDive(input);
        }
    }

    public class Day2
    {
        public List<Command> ReadInput()
        {
            var input = File.ReadAllLines("input.txt");

            var result = input.Select(x => new Command
            {
                Position = x.Substring(0, x.LastIndexOf(' ')),
                Value = int.Parse(x.Substring(x.LastIndexOf(' ') + 1))
            }).ToList();

            return result;
        }

        public int CalculateDive(List<Command> commands)
        {
            var result = commands.GroupBy(x => x.Position)
                .Select(c => new
                {
                    Position = c.Key,
                    Value = c.Sum(x => x.Value)
                });

            var up = result.FirstOrDefault(x => x.Position == "up").Value;
            var down = result.FirstOrDefault(x => x.Position == "down").Value;
            var forward = result.FirstOrDefault(x => x.Position == "forward").Value;

            return (down - up) * forward;
        }

        public int CalculateChangedDive(List<Command> commands)
        {
            var aim = 0;
            var horizontal = 0;
            var depth = 0;

            foreach (var command in commands)
            {
                switch (command.Position)
                {
                    case "up":
                        aim -= command.Value;
                        break;
                    case "down":
                        aim += command.Value;
                        break;
                    case "forward":
                        horizontal += command.Value;
                        depth += command.Value * aim;
                        break;
                    default:
                        break;
                }
            }

            return horizontal * depth;
        }
    }

    public class Command
    {
        public string Position { get; set; }

        public int Value { get; set; }
    }
}
