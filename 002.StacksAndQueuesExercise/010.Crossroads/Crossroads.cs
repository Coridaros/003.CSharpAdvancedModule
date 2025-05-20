//Stacks and queues - exercise, Task 010
//20.05.2025, 23:37

int greenLight = int.Parse(Console.ReadLine());
int freeWindows = int.Parse(Console.ReadLine());

int totalPassedCars = 0;
Queue<string> queue = new Queue<string>();

while(true)
{
    string command = Console.ReadLine();

    if(command == "END")
    {
        Console.WriteLine("Everyone is safe.");
        Console.WriteLine($"{totalPassedCars} total cars passed the crossroads.");
        break;
    }
    else if(command == "green")
    {
        int currentTime = greenLight;

        while(queue.Count > 0 && currentTime > 0)
        {
            string car = queue.Dequeue();

            if (car.Length <= currentTime)
            {
                totalPassedCars++;
                currentTime -= car.Length;
            }
            else
            {
                if (car.Length <= currentTime + freeWindows)
                {
                    totalPassedCars++;
                }
                else
                {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{car} was hit at {car[currentTime + freeWindows]}.");
                    return;
                }
            }
        }
    }
    else
    {
        queue.Enqueue(command);
    }
}