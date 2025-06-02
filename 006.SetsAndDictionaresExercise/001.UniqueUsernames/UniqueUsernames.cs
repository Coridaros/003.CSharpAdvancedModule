//Sets and dictionaries - exercise, Task 001
//02.06.2025, 22:49

public class UniqueUsernames
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> usernames = new HashSet<string>();

        for(int i = 0; i < n; i++)
        {
            usernames.Add(Console.ReadLine());
        }

        foreach(string username in usernames)
        {
            Console.WriteLine(username);
        }
    }
}