//Generics - exercise, Task 006
//20.06.2025, 00:53

namespace GenericCountMethodString;

public class StartUp
{
    static void Main()
    {
        var boxes = new List<Box<double>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));

            boxes.Add(box);
        }

        double compare = double.Parse(Console.ReadLine());

        Console.WriteLine(Count(boxes, compare));
    }

    public static int Count<T>(List<Box<T>> list, T element) where T : IComparable<T>
    {
        int count = 0;

        foreach (var item in list)
        {
            if (item.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }
}