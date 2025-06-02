//Sets and dictionaries - exercise, Task 002
//02.06.2025, 22:54


public class SetsOfElements
{
    static void Main()
    {
        int n;
        int m;
        string[] input;
        HashSet<int> firstSet = new HashSet<int>(); //Сет 1
        HashSet<int> secondSet = new HashSet<int>(); //Сет 2

        input = Console.ReadLine().Split();
        n = int.Parse(input[0]);
        m = int.Parse(input[1]);

        //пълним първия сет
        for(int i = 0; i < n; i ++)
        {
            firstSet.Add(int.Parse(Console.ReadLine()));
        }

        //пълним втория сет
        for(int i = 0; i < m; i++)
        {
            secondSet.Add(int.Parse(Console.ReadLine()));
        }

        firstSet.IntersectWith(secondSet);

        Console.WriteLine(string.Join(" ", firstSet));
    }
}