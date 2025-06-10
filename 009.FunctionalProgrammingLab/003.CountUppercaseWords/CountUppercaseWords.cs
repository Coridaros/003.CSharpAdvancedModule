//Functional programming - lab, Task 003
//10.06.2025, 01:23

public class CountUppercaseWords
{
    static void Main()
    {
        Predicate<string> checker = n => n[0] == n.ToUpper()[0];

        string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => checker(x)).ToArray();

        foreach(string word in words)
        {
            Console.WriteLine(word);
        }
    }
}