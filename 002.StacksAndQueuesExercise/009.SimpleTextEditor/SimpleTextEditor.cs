//Stacks and queues - exercise, Task 009
//20.05.2025, 23:03

int n = int.Parse(Console.ReadLine());

string text = string.Empty;
Stack<string> textEditor = new Stack<string>();

for(int i = 0; i < n; i++)
{
    string[] commandInfo = Console.ReadLine().Split().ToArray();
    string command = commandInfo[0];

    if(command == "1")
    {
        textEditor.Push(text);
        text += commandInfo[1];
    }
    else if(command == "2")
    {
        textEditor.Push(text);
        int startIndex = text.Length - int.Parse(commandInfo[1]);
        text = text.Remove(startIndex);
    }
    else if(command == "3")
    {
        int index = int.Parse(commandInfo[1]);
        Console.WriteLine(text[index - 1]);
    }
    else if(command == "4")
    {
        text = textEditor.Pop();
    }
}