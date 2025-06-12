//Functional programming - exercise, Task 004
//10.06.2025, 11:28

public class FindEvensOrOdds
{
    static void Main()
    {
        Predicate<int> isOdd = null;
        List<int> list = new List<int>();

        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int start = input[0];
        int end = input[1];

        for(int i = start; i <= end; i++)
        {
            list.Add(i);
        }

        string command = Console.ReadLine();

        if(command == "odd")
        {
            isOdd = number => number % 2 != 0;
        }
        else if(command == "even")
        {
            isOdd = number => number % 2 == 0;
        }

        Console.WriteLine(string.Join(" ", list.FindAll(isOdd)));
    }
}