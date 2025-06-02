//Sets and dictionaries - exercise, Task 003
//02.06.2025, 23:05

public class PeriodicTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedSet<string> elements = new SortedSet<string>();
        
        for(int i = 0; i < n; i++)
        {
            string[] currElement = Console.ReadLine().Split(" ");

            foreach(string element in currElement)
            {
                elements.Add(element);
            }
        }

        Console.WriteLine(string.Join(" ", elements));
    }
}