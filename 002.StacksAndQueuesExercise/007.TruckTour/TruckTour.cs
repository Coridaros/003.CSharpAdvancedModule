//Stacks and queues - exercise, Task 007
//20.05.2025, 21:48

int n = int.Parse(Console.ReadLine());

int startIndex = 0;
int currentPetrol = 0;

for(int i = 0; i < n; i++)
{
    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int fuel = data[0];
    int distance = data[1];

    currentPetrol += fuel - distance;

    if(currentPetrol < 0)
    {
        startIndex = i + 1;
        currentPetrol = 0;
    }
}

Console.WriteLine(startIndex);