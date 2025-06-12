//Functional programming - exercise, Task 006
//10.06.2025, 19:34

public class ReverseAndExclude
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());

        Action<List<int>> removeAll = list => list.RemoveAll(x => x % n == 0);

        removeAll(numbers);

        numbers.Reverse();

        Console.WriteLine(string.Join(" ", numbers));
    }
}