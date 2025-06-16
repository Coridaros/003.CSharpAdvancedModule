//Defining classes - exercise, Task 002
//14.06.2025, 23:36

namespace DefiningClasses;

public class StartUp
{
    static void Main()
    {
        Person firstPerson = new Person();

        Console.WriteLine($"{firstPerson.Name} - {firstPerson.Age}");

        Person secondPerson = new Person(20);

        Person thirdPerson = new Person("Pesho", 22);

        Console.WriteLine($"{thirdPerson.Name} - {thirdPerson.Age}");
    }
}