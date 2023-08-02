public class TestTech {
    public static void Main(string[] args)
    {
        var test = new Util();
        var testNull = new StringCompare() { First = "123456789 ", Second = "123456789" };
        var testWithValue = new StringCompare() { First = "123 ", Second = "123" };
        string responseNull = test.CompareValues(testNull);
        Console.WriteLine($"Response null - {responseNull}");

        string responseValue = test.CompareValues(testWithValue);
        Console.WriteLine($"Response with value - {responseValue}");

    }

}

public class Util {
    public string CompareValues(StringCompare stringCompare) {
        int total = stringCompare.First.Length + stringCompare.Second.Length;
        if(total > 10)
        {
            return null;
        }
        else
        {
            return stringCompare.Second;
        }
    }
}

public class StringCompare
{
    public string First { get; set; }
    public string Second { get; set; }
}

