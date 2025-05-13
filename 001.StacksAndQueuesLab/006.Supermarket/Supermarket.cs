//Stacks and queues - lab, Task 006
//14.05.2025, 00:57

Queue<string> market = new Queue<string>();

while(true)
{
    string text = Console.ReadLine();

    if(text == "Paid")
    {
        while(market.Count > 0)
        {
            Console.WriteLine(market.Dequeue());
        }
    }
    else if(text == "End")
    {
        int rCnt = market.Count;
        Console.WriteLine($"{rCnt} people remaining.");
        break;
    }
    else
    {
        market.Enqueue(text);
    }
}