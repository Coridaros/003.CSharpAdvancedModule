//Functional programming - lab, Task 002
//10.06.2025, 01:18

public class SumNumbers
{
    static void Main()
    {
        Func<string, int> parser = x => int.Parse(x);

        int[] numbers = Console.ReadLine().Split(", ").Select(parser).ToArray();

        Console.WriteLine(numbers.Count());
        Console.WriteLine(numbers.Sum());
    }
}