//Stacks and queues - lab, Task 003
//13.05.2025, 23:02

var input = Console.ReadLine().Split().Reverse();

Stack<string> stack = new Stack<string>(input);

int result = int.Parse(stack.Pop());

while(stack.Count > 0)
{
    string operation = stack.Pop();
    int number = int.Parse(stack.Pop());

    if (operation == "+")
    {
        result += number;
    }
    else if (operation == "-")
    {
        result -= number;
    }
}

Console.WriteLine(result);

