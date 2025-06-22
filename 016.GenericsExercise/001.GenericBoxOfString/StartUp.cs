//Generics - exercise, Task 001
//19.06.2025, 15:19

namespace GenericBoxOfString;

public class StartUp
{
    static void Main()
    {
        Box<string> box = new Box<string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            box.Add(input);

            Console.WriteLine(box.ToString());
            box.Clear();
        }
    }
}