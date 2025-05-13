//Stack and queues - lab, Task 002
//13.05.2025, 22:49

var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> stack = new Stack<int>(inputs);

while(true)
{
    string command = Console.ReadLine().ToLower();
    string[] tokens = command.Split().ToArray();

    if (tokens[0] == "add")
    {
        int firstN = int.Parse(tokens[1]);
        int secondN = int.Parse(tokens[2]);

        stack.Push(firstN);
        stack.Push(secondN);
    }
    else if (tokens[0] == "remove")
    {
        int count = int.Parse(tokens[1]);

        if(count <= stack.Count)
        {
            for (int i = 0; i < count; i++)
            {
                stack.Pop();
            }
        }
    }
    else if (command == "end")
    {
        Console.WriteLine($"Sum: {stack.Sum()}");
        break;
    }
}