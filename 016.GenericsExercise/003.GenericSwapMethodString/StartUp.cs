//Generics - exercise, Task 003
//20.06.2025, 00:44

namespace GenericSwapMethodString;

public class StartUp
{
    static void Main()
    {
        Box<string> box = new Box<string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            box.Add(Console.ReadLine());
        }

        int[] swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int firstIndex = swapIndexes[0];
        int secondIndex = swapIndexes[1];

        var list = box.ToList();
        box.Swap(list, firstIndex, secondIndex);

        Console.WriteLine(box.ToString());
    }
}