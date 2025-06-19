//Implementing stack and queue - lab
//19.06.2025, 15:05

public class ImplementingStackAndQueue
{
    static void Main()
    {
        #region Stack Structure Testing
        CustomStack customStack = new CustomStack();

        Console.WriteLine();
        customStack.Push(1);
        customStack.Push(2);
        customStack.Push(3);
        customStack.Push(4);
        customStack.Push(5);

        Console.WriteLine("Printing original stack without removing the elements:");
        Console.WriteLine(customStack.ToString() + Environment.NewLine);

        //Current count of the stack
        Console.WriteLine("Count: " + customStack.Count + Environment.NewLine);

        //Peek() - should return 5
        Console.WriteLine("Peek(): " + customStack.Peek() + Environment.NewLine);

        //Pop() - should return 5 and remove it from the collection - new count = 4
        Console.WriteLine("Pop(): " + customStack.Pop() + Environment.NewLine);

        //Current count and elements of the stack
        Console.WriteLine("Count: " + customStack.Count + Environment.NewLine);
        Console.WriteLine("Current elements in the stack:");
        Console.WriteLine(customStack.ToString() + Environment.NewLine);

        customStack.Push(5);
        customStack.Push(6);

        //Current count and elements of the stack
        Console.WriteLine("Count: " + customStack.Count + Environment.NewLine);
        Console.WriteLine("Current elements in the stack:");
        Console.WriteLine(customStack.ToString() + Environment.NewLine);
        #endregion

        #region Queue Structure Testing
        CustomQueue customQueue = new CustomQueue();

        //Adding elements to the Queue
        customQueue.Enqueue(1);
        customQueue.Enqueue(2);
        customQueue.Enqueue(3);

        Console.WriteLine("Printing original queue without removing the elements:");
        customQueue.ForEach(n => Console.WriteLine(n));
        Console.WriteLine();

        //Removing the first element from the Queue with Dequeue method (1)
        Console.WriteLine("Dequeue(): " + customQueue.Dequeue() + Environment.NewLine);

        //Printing the Queue Count which is now 2
        Console.WriteLine("Count: " + customQueue.Count + Environment.NewLine);

        //Adding two new elements to the Queue -> 4, 5
        customQueue.Enqueue(4);
        customQueue.Enqueue(5);

        //The collection is now 2, 3, 4, 5 with Count: 4
        customQueue.ForEach(n => Console.WriteLine(n));

        //Clear the Queue with .Clear() method -> removes all elements in the Queue
        customQueue.Clear();

        //Now we don't have anything in the Queue so the Count is restarted to 0
        Console.WriteLine(Environment.NewLine + "Count: " + customQueue.Count);
        #endregion

    }
}