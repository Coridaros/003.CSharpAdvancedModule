//Functional programming - exercise, Task 007
//10.06.2025, 19:50

public class PredicateForNames
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> namesList = Console.ReadLine().Split().ToList();

        //намираме всички имена от списъка които отговарят на условието (x => x.Length <= n) и връщаме нов лист
        Func<List<string>, List<string>> findAllNamesWithLen = list => list.FindAll(x => x.Length <= n).ToList();

        namesList = findAllNamesWithLen(namesList);

        Console.WriteLine(string.Join("\r\n", namesList));
    }
}