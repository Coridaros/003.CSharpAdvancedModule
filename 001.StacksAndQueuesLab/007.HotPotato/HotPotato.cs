//Stack and queues - lab, Task 007
//14.05.2025, 01:06

var players = Console.ReadLine().Split().ToArray();
int n = int.Parse(Console.ReadLine());

Queue<string> names = new Queue<string>(players);

while(names.Count > 1)
{
    for(int i = 1; i < n; i++)
    {
        string player = names.Dequeue();
        names.Enqueue(player);
    }

    string removedPLayer = names.Dequeue();
    Console.WriteLine($"Removed {removedPLayer}");
}

string lastPlayer = names.Dequeue();
Console.WriteLine($"Last is {lastPlayer}");

