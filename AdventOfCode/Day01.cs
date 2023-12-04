using System.Runtime.InteropServices;
using Spectre.Console.Rendering;

namespace AdventOfCode;

public class Day01 : BaseDay
{
    private readonly string _input;

    public Day01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public override ValueTask<string> Solve_1()
    {
        char[] digits = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
        IEnumerable<int> result = [];

        foreach (var line in _input.Split('\n'))
        {
            if (line == "") break;
            int firstIndex = line.IndexOfAny(digits);
            int lastIndex = line.LastIndexOfAny(digits);
            char first = line[firstIndex];
            char last = line[lastIndex];
            result = result.Append(int.Parse($"{first}{last}"));
        }
        return new($"Solution to {ClassPrefix} {CalculateIndex()}, part 1: {result.Sum()}");
    }

    public override ValueTask<string> Solve_2()
    {
        string[] numbers = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        char[] digits = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'];
        IEnumerable<int> result = [];

        foreach (var line in _input.Split('\n'))
        {
            string firstNum = "0";
            string lastNum = "0";
            int firstIndex = line.IndexOfAny(digits);
            if (firstIndex != -1)
            {
               firstNum = line[firstIndex].ToString();
            }
            int lastIndex = line.LastIndexOfAny(digits);
            if (lastIndex != -1)
            {
               lastNum = line[lastIndex].ToString();
            }
            foreach (var num in numbers.Select((x, i) => new { Value = x, Index = i }))
            {
                var idx = line.IndexOf(num.Value);
                var lastIdx = line.LastIndexOf(num.Value);
                if (idx != -1 && (idx < firstIndex || firstNum == "0"))
                {
                    firstIndex = idx;
                    firstNum = num.Index.ToString();
                }
                if (lastIdx > lastIndex)
                {
                    lastIndex = lastIdx;
                    lastNum = num.Index.ToString();
                }
            }

            result = result.Append(int.Parse($"{firstNum}{lastNum}"));
        }
        return new($"Solution to {ClassPrefix} {CalculateIndex()}, part 2: {result.Sum()}");
    }
}
