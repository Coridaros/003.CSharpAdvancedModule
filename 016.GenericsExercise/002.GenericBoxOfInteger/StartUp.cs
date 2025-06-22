//Generics - exercise, Task 002
//19.06.2025, 15:22

using GenericBoxOfInteger;

public class StartUp
{
    static void Main()
    {
        Box<int> box = new Box<int>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            box.Add(number);

            Console.WriteLine(box.ToString());
            box.Clear();
        }
    }
}