//Stacks and queues - exercise, Task 008
//20.05.2025, 22:09

Stack<char> stack = new Stack<char>();
Dictionary<char, char> parenthesis = new Dictionary<char, char>
{
    { ')', '(' },
    { ']', '[' },
    { '}', '{' }
};

string input = Console.ReadLine();


string IsBalanced(Stack<char> stack, Dictionary<char, char> dict, string s)
{
    foreach (char symbol in input)
    {
        if (parenthesis.ContainsValue(symbol))
        {
            stack.Push(symbol);
        }
        else if (parenthesis.ContainsKey(symbol))
        {
            if (stack.Count == 0 || stack.Pop() != parenthesis[symbol])
            {
                return "NO";
            }
        }
    }

    return stack.Count == 0 ? "YES" : "NO";
}

Console.WriteLine(IsBalanced(stack, parenthesis, input));