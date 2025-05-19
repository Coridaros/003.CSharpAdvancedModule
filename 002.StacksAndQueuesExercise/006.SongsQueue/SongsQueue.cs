//Stacks and queues - exercise, Task 006
//17.05.2025, 00:25

string[] songs = Console.ReadLine().Split(", ").ToArray();

Queue<string> playList = new Queue<string>();
HashSet<string> uniqueSongs = new HashSet<string>();

foreach(var item in songs)
{
    if(uniqueSongs.Add(item))
    {
        playList.Enqueue(item);
    }
}

while(playList.Count > 0)
{
    string[] input = Console.ReadLine().Split().ToArray();
    string cmd = input[0];

    if(cmd == "Add")
    {
        string song = string.Join(' ', input.Skip(1));

        if(uniqueSongs.Add(song))
        {
            playList.Enqueue(song);
        }
        else
        {
            Console.WriteLine($"{song} is already contained!");
        }
    }
    else if(cmd == "Play")
    {
        string removedSong = playList.Dequeue();
        uniqueSongs.Remove(removedSong);
    }
    else if(cmd == "Show")
    {
        Console.WriteLine(string.Join(", ", playList));
    }
}

Console.WriteLine("No more songs!");