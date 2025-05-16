//Stack and queues - exercise, Task 002
//16.05.2025, 00:35

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> queue = new Queue<int>(numbers);

int s = input[1];
int x = input[2];

for(int i = 0; i < s; i++)
{
    queue.Dequeue();
}

if(queue.Count == 0)
{
    Console.WriteLine(0);
}
else if(queue.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}