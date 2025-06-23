//Iterators and comparators - exercise, Task 003
//20.06.2025, 10:40

namespace Stack;

public class StartUp
{
    static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] input = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            switch (input[0])
            {
                case "Push":
                    string[] itemsToPush = input.Skip(1).ToArray();
                    foreach (var item in itemsToPush)
                    {
                        stack.Push(item);
                    }
                    break;

                case "Pop":
                    try
                    {
                        stack.Pop();
                    }
                    catch
                    {
                    }
                    break;
            }
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}