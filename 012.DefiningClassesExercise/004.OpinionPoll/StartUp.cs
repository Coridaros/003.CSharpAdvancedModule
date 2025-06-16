//Difining classes - exercise, Task 004
//15.06.2025, 00:35

using System;

namespace DefiningClasses;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Family family = new Family();

        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string name = input[0];
            int age = int.Parse(input[1]);

            Person person = new Person(name, age);

            family.AddMember(person);
        }

        List<Person> p = family.People.Where(pp => pp.Age > 30).ToList();

        foreach(var item in p.OrderBy(x => x.Name))
        {
            Console.WriteLine($"{item.Name} - {item.Age}");
        }
    }
}