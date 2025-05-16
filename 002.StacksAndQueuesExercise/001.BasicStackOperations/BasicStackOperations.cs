//Stacks and queues - exercise, Task 002
//16.05.2025, 00:18

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> stack = new Stack<int>(numbers);

int s = input[1];
int x = input[2];

for(int i = 0; i < s; i++)
{
    stack.Pop();
}

if(stack.Count == 0)
{
    Console.WriteLine(0);
}
else if(stack.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}