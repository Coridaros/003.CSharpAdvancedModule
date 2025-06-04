//Sets and dictionaries advanced - exercise, Task 007
//04.06.2025, 00:49



public class TheVLogger
{
    static void Main()
    {
        Dictionary<string, HashSet<string>> followers = new Dictionary<string, HashSet<string>>();
        Dictionary<string, int> followings = new Dictionary<string, int>();

        ReadData(followers, followings);
        PrintData(followers, followings);
    }


    private static void ReadData(Dictionary<string, HashSet<string>> followers, Dictionary<string, int> followings)
    {
        string input = Console.ReadLine();

        while(input != "Statistics")
        {
            string[] tokens = input.Split().ToArray();
            string command = tokens[1];

            if(command == "joined")
            {
                string vloggerName = tokens[0];

                if(!followers.ContainsKey(vloggerName))
                {
                    followers[vloggerName] = new HashSet<string>();
                    followings[vloggerName] = 0;
                }
            }
            else if(command == "followed")
            {
                string vloggerNameOne = tokens[0];
                string vloggerNameTwo = tokens[2];

                if(followers.ContainsKey(vloggerNameOne) && followers.ContainsKey(vloggerNameTwo) && 
                    vloggerNameOne != vloggerNameTwo)
                {
                    if(!followers[vloggerNameOne].Contains(vloggerNameTwo))
                    {
                        followers[vloggerNameTwo].Add(vloggerNameOne);
                        followings[vloggerNameTwo]++;
                    }
                }
            }

            input = Console.ReadLine();
        }
    }

    private static void PrintData(Dictionary<string, HashSet<string>> followers,
        Dictionary<string, int> followings)
    {
        Console.WriteLine($"The V-Logger has a total of {followers.Count} vloggers in its logs.");

        var sortedVloggers = followers
            .OrderByDescending(v => v.Value.Count)
            .ThenBy(v => followings[v.Key])
            .ToList();

        var mostFamous = sortedVloggers.First();

        Console.WriteLine($"1. {mostFamous.Key} : {mostFamous.Value.Count} followers, {followings[mostFamous.Value]} following");

        foreach (var follower in mostFamous.Value.OrderBy(f => f))
        {
            Console.WriteLine($"*  {follower}");
        }

        int rank = 2;
        foreach (var vlogger in sortedVloggers.Skip(1))
        {
            Console.WriteLine($"{rank}. {vlogger.Key} : {vlogger.Value.Count} followers, {followings[vlogger.Key]} following");
            rank++;
        }
    }
}