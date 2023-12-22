namespace Day1;

public static class Program
{
    public static void Main()
    {
        var sample1 = File.ReadAllLines("./sample1.txt");
        var sample2 = File.ReadAllLines("./sample2.txt");
        var input = File.ReadAllLines("./input.txt");

        var part1Sample = new CalibrationValues();
        foreach (var s in sample1)
        {
            part1Sample.AddDigitsOnly(s);
        }

        var part1Input = new CalibrationValues();
        foreach (var s in input)
        {
            part1Input.AddDigitsOnly(s);
        }

        var part2Sample = new CalibrationValues();
        foreach (var s in sample2)
        {
            part2Sample.AddAllNumber(s);
        }

        var part2Input = new CalibrationValues();
        foreach (var s in input)
        {
            part2Input.AddAllNumber(s);
        }

        Console.WriteLine($"Part 1 Sample 1: {part1Sample.Sum()}");
        Console.WriteLine($"Part 1 Input: {part1Input.Sum()}");
        Console.WriteLine($"Part 2 Sample 2: {part2Sample.Sum()}");
        Console.WriteLine($"Part 2 Input: {part2Input.Sum()}");
    }
}