//Stacks and queues - exercise, Task 003
//16.05.2025, 00:41

using System.IO.Pipes;
using System.Threading.Tasks.Dataflow;

int n = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for(int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

    int command = input[0];

    if(command == 1)
    {
        stack.Push(input[1]);
    }
    else if(command == 2)
    {
        stack.Pop();
    }
    else if(command == 3)
    {
        if(stack.Count > 0)
        {
            Console.WriteLine(stack.Max());
        }
    }
    else if(command == 4)
    {
        if(stack.Count > 0)
        {
            Console.WriteLine(stack.Min());
        }
    }
}

Console.WriteLine(string.Join(", ", stack));