//Stacks and queues - lab, Task 004
//13.05.2025, 23:41

string str = Console.ReadLine();

Stack<int> stack = new Stack<int>();

for(int i = 0; i < str.Length; i++)
{
    if (str[i] == '(')
    {
        stack.Push(i);
    }
    else if (str[i] == ')')
    {
        int startIndex = stack.Pop();
        int endIndex = i;

        string result = str.Substring(startIndex, endIndex - startIndex + 1);

        Console.WriteLine(result);
    }
}