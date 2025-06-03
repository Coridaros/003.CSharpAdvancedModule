//Sets and dictionaries advanced - exercise, Task 004
//02.06.2025, 23:40

public class EvenTimes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<int, int> numbers = new Dictionary<int, int>();

        for(int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            //ако не се съдържа числото го добавяме към ключовете и му слагаме стойност 1
            if(!numbers.ContainsKey(number))
            {
                numbers.Add(number, 1);
            }
            else
            {
                //ако се съдържа му увеличаваме стойноста с 1
                numbers[number]++;
            }
        }

        Console.WriteLine(numbers.First(x => x.Value % 2 == 0).Key);
    }
}