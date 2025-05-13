//Stacks and queues - lab, Task 001
//13.05.2025, 21:31

string input = Console.ReadLine();

Stack<char> stack = new Stack<char>();

for(int i = 0; i < input.Length; i++)
{
    stack.Push(input[i]);
}

while(stack.Count > 0)
{
    Console.Write(stack.Pop());
}