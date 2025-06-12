//Fuctional programming - exercise, Task 001
//10.06.2025, 11:01

public class ActionPrint
{
    static void Main()
    {
        List<string> names = Console.ReadLine().Split().ToList();

        Action<string> printName = name => Console.WriteLine(name);

        names.ForEach(printName);
    }
}