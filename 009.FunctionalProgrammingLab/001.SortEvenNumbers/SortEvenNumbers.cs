//Functional programming - lab, Task 001
//10.06.2025, 01:11

public class SortEvenNumbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).Where(x => x % 2 == 0).OrderBy(x => x).ToArray();

        Console.WriteLine(string.Join(", ", numbers));
    }
}