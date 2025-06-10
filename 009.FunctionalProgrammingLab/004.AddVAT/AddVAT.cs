//Functional programming - lab, Task 004
//10.06.2025, 01:31

public class AddVAT
{
    static void Main()
    {
        double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
            .Select(x => x * 1.20).ToArray();

        foreach(var item in prices)
        {
            Console.WriteLine($"{item:F2}");
        }
    }
}