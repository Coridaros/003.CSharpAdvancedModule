//Exam preparation, Task 001
//19.06.2025, 00:36

public class EnergyDrinks
{
    static void Main()
    {
        int[] caffeineInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int[] energyDrinksInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        Stack<int> caffeine = new Stack<int>(caffeineInput);
        Queue<int> energyDrinks = new Queue<int>(energyDrinksInput);

        int stamatMax = 0;

        while(caffeine.Count > 0 && energyDrinks.Count > 0)
        {
            int sum = caffeine.Peek() * energyDrinks.Peek();
            int total = sum + stamatMax;

            if(total <= 300)
            {
                caffeine.Pop();
                energyDrinks.Dequeue();
                stamatMax += sum;
            }
            else
            {
                caffeine.Pop();
                int firstDrink = energyDrinks.Dequeue();
                energyDrinks.Enqueue(firstDrink);

                stamatMax = Math.Max(0, stamatMax - 30);
            }
        }

        if(energyDrinks.Count > 0)
        {
            Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
        }
        else
        {
            Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
        }

        Console.WriteLine($"Stamat is going to sleep with {stamatMax} mg caffeine.");
    }
}