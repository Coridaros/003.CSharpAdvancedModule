//Iterators and comparators - exercise, Task 004
//20.06.2025, 10:42

namespace Froggy;

public class StartUp
{
    static void Main(string[] args)
    {
        var lake = new Lake(Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList());

        Console.WriteLine(String.Join(", ", lake));
    }
}