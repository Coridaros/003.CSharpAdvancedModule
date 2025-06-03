//Sets and dictionaries advanced - exercise, Task 005
//02.06.2025, 23:48

public class CountSymbols
{
    static void Main()
    {
        SortedDictionary<char, int> times = new SortedDictionary<char, int>();

        string text = Console.ReadLine();

        for(int i = 0; i < text.Length; i++)
        {
            char symbol = text[i];

            if(!times.ContainsKey(symbol))
            {
                times.Add(symbol, 1);
            }
            else
            {
                times[symbol]++;
            }
        }

        foreach(var item in times)
        {
            Console.WriteLine($"{item.Key}: {item.Value} time/s");
        }
    }
}