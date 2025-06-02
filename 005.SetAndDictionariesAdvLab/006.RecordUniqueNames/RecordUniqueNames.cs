//Sets and dictionaries advanced - lab, Task 006
//28.05.2025, 01:05

public class RecordUniqueNames
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> names = new HashSet<string>();

        for(int i = 0; i < n; i++)
        {
            names.Add(Console.ReadLine());
        }

        foreach(var name in names)
        {
            Console.WriteLine(name);
        }
    }
}