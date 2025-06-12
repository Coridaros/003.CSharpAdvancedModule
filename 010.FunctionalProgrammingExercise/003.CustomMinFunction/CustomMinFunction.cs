//Functional programming - exercise, Task 003
//10.06.2025, 11:09

public class CustomMinFunction
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        Func<List<int>, int> minNumber = nums => nums.Min();

        Console.WriteLine(minNumber(numbers));
    }
}