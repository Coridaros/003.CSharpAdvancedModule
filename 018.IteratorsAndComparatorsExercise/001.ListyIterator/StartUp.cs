//Iterators and comparators - exercise, Task 001
//20.06.2025, 10:34

namespace ListyIterator;

public class StartUp
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Skip(1).ToList();

        var listyIterator = new ListyIterator<string>(input);

        string command = Console.ReadLine();

        while (command != "END")
        {
            switch (command)
            {
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
                case "Print":
                    Console.WriteLine(listyIterator.Print());
                    break;
            }

            command = Console.ReadLine();
        }
    }
}