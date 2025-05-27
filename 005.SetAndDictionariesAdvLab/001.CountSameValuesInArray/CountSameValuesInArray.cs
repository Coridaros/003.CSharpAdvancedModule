//Set and dictionaries advanced - lab, Task 001
//26.05.2025, 21:01

public class CountSameValuesInArray
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        Dictionary<double, int> counts = new Dictionary<double, int>();

        foreach(var item in numbers)
        {
            if(!counts.ContainsKey(item))
            {
                counts[item] = 1;
            }
            else
            {
                counts[item]++;
            }
        }

        foreach(var item in counts)
        {
            Console.WriteLine($"{item.Key} - {item.Value} times");
        }
    }
}