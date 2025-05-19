//Stacks and queues - exercise, Task 005
//16.05.2025, 22:52

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rackCapacity = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>(input);

int rackCnt = 0;
int sum = 0;

while(stack.Count > 0)
{
    int curElement = stack.Pop();

    if(sum < curElement)
    {
        rackCnt++;
        sum = rackCapacity;
    }

    sum -= curElement;
}

Console.WriteLine(rackCnt);