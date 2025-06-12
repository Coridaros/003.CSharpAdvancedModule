//Functional programming - exercise, Task 008
//12.06.2025, 21:14

public class ListOfPredicates
{
    static void Main()
    {
        long n = int.Parse(Console.ReadLine());

        var dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> result = new List<int>();

        List<Predicate<int>> predicates = new List<Predicate<int>>(dividers.Count);

        foreach (var divider in dividers)
        {
            predicates.Add(n => n % divider == 0);
        }

        for (int i = 1; i <= n; i++)
        {
            bool isDivisible = true;

            foreach (var predicate in predicates)
            {
                if (!predicate(i))
                {
                    isDivisible = false;
                }
            }
            if (isDivisible)
            {
                result.Add(i);
            }
        }

        Console.WriteLine(String.Join(" ", result));
    }
}