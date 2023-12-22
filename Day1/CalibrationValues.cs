namespace Day1;

public class CalibrationValues
{
    readonly List<string> _values = [];

    public void AddDigitsOnly(string newValue)
    {
        var val = newValue
            .Where(char.IsDigit)
            .Aggregate("", (current, value) => current + value);

        _values.Add(val);
    }

    public void AddAllNumber(string newValue)
    {
        var current = TokenizeLine(newValue);
        _values.Add(current);
    }

    static string TokenizeLine(string line)
    {
        var spelledOutNumbers = new Dictionary<string, string>
        {
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" },
            { "zero", "0" }
        };

        var digitNames = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var token = "";

        for (var i = 0; i < line.Length; i++)
        {
            var letter = line[i];
            if (char.IsDigit(letter))
            {
                token += letter.ToString();
                continue;
            }

            foreach (var name in digitNames)
            {
                if (line.Length < name.Length + i)
                {
                    continue;
                }

                var sub = line.Substring(i, name.Length);
                if (!spelledOutNumbers.TryGetValue(sub, out var number)) continue;
                token += number;
                break;
            }
        }

        return token;
    }

    public long Sum()
    {
        long sum = 0;

        foreach (var value in _values)
        {
            var currentNumber = value[0] + value[^1].ToString();
            sum += int.Parse(currentNumber);
        }

        return sum;
    }
}