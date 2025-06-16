//Defining classes - exercise, Task 005
//15.06.2025, 00:46

using System.Globalization;

namespace DateModifier;

public class DateModifier
{
    //private int days;

    //public int Days { get; set; }

    public static int CalculateDiff(string dateOne, string dateTwo)
    {
        DateTime firstDate = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

        int diff = Math.Abs((firstDate - secondDate).Days);

        return diff;
    }
}

public class Test
{
    static void Main()
    {
        string dateOne = Console.ReadLine();
        string dateTwo = Console.ReadLine();

        Console.WriteLine(DateModifier.CalculateDiff(dateOne, dateTwo));
    }
}