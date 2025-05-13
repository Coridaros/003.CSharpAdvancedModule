//Stacks and queues - lab, Task 008
//14.05.2025, 01:17

int n = int.Parse(Console.ReadLine());

int carPassedCnt = 0;

Queue<string> cars = new Queue<string>();

while(true)
{
    string command = Console.ReadLine();

    if(command == "green")
    {
        for(int i = 0; i < n; i++)
        {
            if(cars.Count > 0)
            {
                Console.WriteLine($"{cars.Dequeue()} passed!");
                carPassedCnt++;
            }
        }
    }
    else if(command == "end")
    {
        Console.WriteLine($"{carPassedCnt} cars passed the crossroads.");
        break;
    }
    else
    {
        cars.Enqueue(command);
    }
}