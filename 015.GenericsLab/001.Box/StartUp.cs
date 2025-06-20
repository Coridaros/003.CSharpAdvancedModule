//Generics - lab, Task 001
//19.06.2025, 15:12

namespace BoxOfT;

public class StartUp
{
    static void Main()
    {
        Box<int> box = new Box<int>();

        box.Add(1);
        box.Add(2);
        box.Add(3);

        Console.WriteLine(box.Remove());

        box.Add(4);
        box.Add(5);

        Console.WriteLine(box.Remove());
    }
}