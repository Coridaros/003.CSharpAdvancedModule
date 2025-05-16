//Stacs and queues - exercise, Task 004
//16.05.2025, 01:35

int food = int.Parse(Console.ReadLine());



var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

int queCnt = queue.Count;
int max = queue.Max();

for (int i = 1; i <= queCnt; i++)
{
    int curElement = queue.Peek();

    if(food >= curElement)
    {
        food -= curElement;
        queue.Dequeue();
    }
    else
    {
        break;
    }
}

Console.WriteLine(max);

if(queue.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" " , queue)}");
}