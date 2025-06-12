//Functional programming - exercise, Task 005
//10.06.2025, 19:17

public class AppliedArithmetics
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command = Console.ReadLine();

        //вземаме лист от числа и към всяко число от списъка прибавяме 1((number => number += 1))
        Func<List<int>, List<int>> add = list => list.Select(number => number += 1).ToList();

        //вземаме списък и всяко едно число го умножаваме по 2 Select(number => number *= 2).ToList()
        Func<List<int>, List<int>> multiply = list => list.Select(number => number *= 2).ToList();

        //получаваме списък с числа и от всяко едно вадим единица -> след това връщаме нов списък
        Func<List<int>, List<int>> subtract = list => list.Select(number => number -= 1).ToList();

        //Принтираме числата от списъка а помоща на Action<T>
        Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));

        while (command != "end")
        {
            if(command == "add")
            {
                numbers = add(numbers);
            }
            else if(command == "multiply")
            {
                numbers = multiply(numbers);
            }
            else if(command == "subtract")
            {
                numbers = subtract(numbers);
            }
            else if(command == "print")
            {
                print(numbers);
            }

            command = Console.ReadLine();
        }
    }
}