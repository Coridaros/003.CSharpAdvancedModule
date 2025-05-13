//Stacks and queues - lab, Task 005
//14.05.2025, 00:35

var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> ints = new Queue<int>();
Queue<int> even = new Queue<int>();

for(int i = 0; i < input.Length; i++)
{
    ints.Enqueue(input[i]);
}

while(ints.Count > 0)
{
    int next = ints.Dequeue();

    if(next % 2 == 0)
    {
        even.Enqueue(next);
    }
}

Console.WriteLine(string.Join(", ", even));