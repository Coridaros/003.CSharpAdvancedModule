//Exam preparation - 2022, Task 001
//17.06.2025, 21:38

public class Blacksmith
{
    static void Main()
    {
        int totalSwords = 0;
        int[] steelInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] carbonInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //стомана -> първия към последния елемент
        Queue<int> steelQueue = new Queue<int>(steelInput);
        //въглерод -> последния към първия елемент
        Stack<int> carbonStack = new Stack<int>(carbonInput);

        SortedDictionary<string, int> swords = new SortedDictionary<string, int>()
        {
            { "Broadsword", 0 },
            { "Sabre", 0 },
            { "Katana", 0 },
            { "Shamshir", 0 },
            { "Gladius", 0 }
        };

        //стоп: ако свърши стоманата или въглерода
        //продължаваме ако имаме стомана или въглерод
        //1.взимам стомана и въглерод (peek)
        //2. сума = стомана + въглерод
        //3. проверка дали сумата може да образува меч
        //4. премахвам стома и меч
        //5. премахваме стоманата и увеличаваме въглерода с 5

        while(steelQueue.Count > 0 && carbonStack.Count > 0)
        {
            int steel = steelQueue.Peek();
            int carbon = carbonStack.Peek();
            int sum = steel + carbon;

            if(sum == 70)
            {
                //изработваме Gladius
                swords["Gladius"]++;
                totalSwords++;
                steelQueue.Dequeue();
                carbonStack.Pop();
            }
            else if(sum == 80)
            {
                //изработваме Shamshir
                swords["Shamshir"]++;
                totalSwords++;
                steelQueue.Dequeue();
                carbonStack.Pop();
            }
            else if(sum == 90)
            {
                //изработваме Katana
                swords["Katana"]++;
                totalSwords++;
                steelQueue.Dequeue();
                carbonStack.Pop();
            }
            else if(sum == 110)
            {
                //изработваме Sabre
                swords["Sabre"]++;
                totalSwords++;
                steelQueue.Dequeue();
                carbonStack.Pop();
            }
            else if(sum == 150)
            {
                //изработваме Broadsword
                swords["Broadsword"]++;
                totalSwords++;
                steelQueue.Dequeue();
                carbonStack.Pop();
            }
            else
            {
                //не изработваме меч
                steelQueue.Dequeue(); // махаме стоманата

                carbon += 5; // увеличаваме carbona

                carbonStack.Pop(); // махаме carbona
                carbonStack.Push(carbon); // добаваме увеличения carbon
            }
        }

        if(totalSwords > 0)
        {
            Console.WriteLine($"You have forged {totalSwords} swords.");
        }
        else
        {
            Console.WriteLine("You did not have enough resources to forge a sword.");
        }

        if(steelQueue.Count == 0)
        {
            Console.WriteLine("Steel left: none");
        }
        else
        {
            Console.WriteLine("Steel left: " + string.Join(", ", steelQueue));
        }

        if(carbonStack.Count == 0)
        {
            Console.WriteLine("Carbon left: none");
        }
        else
        {
            Console.WriteLine("Carbon left: " + string.Join(", ", carbonStack));
        }

        foreach(var item in swords.OrderBy(x => x.Key))
        {
            if(item.Value > 0)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}