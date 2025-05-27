//Set and dictionaries advanced - lab, Task 003
//27.05.2025, 00:55

public class LargestThreeNumbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).Take(3).ToArray();

        Console.WriteLine(string.Join(" ", numbers));
    }
}