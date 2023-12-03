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
}
