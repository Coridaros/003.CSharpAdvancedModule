//Generics - lab, Task 002
//21.06.2025, 00:06

namespace GenericArrayCreator;

public class StartUp
{
    static void Main()
    {
        string[] stringArray = ArrayCreator.Create(5, "Pesho");
        int[] intArray = ArrayCreator.Create(10, 33);
    }
}