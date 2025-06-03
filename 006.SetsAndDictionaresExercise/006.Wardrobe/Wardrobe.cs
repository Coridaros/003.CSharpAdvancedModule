//Sets and dictionaries advanced - exercise, Task 006
//04.06.2025, 00:02



public class Wardrobe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

        for(int i = 0; i < n; i++)
        {
            ReadData(wardrobe);
        }

        PrintData(wardrobe);
    }

    static void ReadData(Dictionary<string, Dictionary<string, int>> wardrobe)
    {
        string inputData = Console.ReadLine();
        string color = inputData.Split(" -> ")[0]; // Вземаме първия елемнт от масива

        if(!wardrobe.ContainsKey(color))
        {
            //добавяме цвета като ключ на главния речник;
            wardrobe.Add(color, new Dictionary<string, int>());
        }

        Dictionary<string, int> clothes = wardrobe[color];

        string[] inputClothes = inputData.Split(" -> ")[1].Split(","); // Вземаме останалата част от масива

        foreach(var cloth in inputClothes)
        {
            if(!clothes.ContainsKey(cloth))
            {
                clothes.Add(cloth, 1);
            }
            else
            {
                clothes[cloth]++;
            }
        }
    }

    private static void PrintData(Dictionary<string, Dictionary<string, int>> wardrobe)
    {
        string[] input = Console.ReadLine().Split().ToArray();
        string colorCloth = input[0];
        string cloth = input[1];

        foreach(var color in wardrobe)
        {
            //Принтираме стойноста на главния ключ
            Console.WriteLine($"{color.Key} clothes:");

            //Вадим вложения речник от стойността на главния за да можем да го изпринтим
            Dictionary<string, int> clothes = color.Value;

            foreach(var item in clothes)
            {
                if(color.Key == colorCloth && item.Key == cloth)
                {
                    Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {item.Key} - {item.Value}");
                }
                
            }
        }
    }
}