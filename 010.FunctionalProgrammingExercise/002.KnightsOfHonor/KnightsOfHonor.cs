//Functional programming - exercise, Task 002
//10.06.2025, 11:05

public class KnightsOfHonor
{
    static void Main()
    {
        List<string> names = Console.ReadLine().Split().ToList();

        Action<string> title = name => Console.WriteLine($"Sir {name}");

        foreach(string name in names)
        {
            title(name);
        }
    }
}