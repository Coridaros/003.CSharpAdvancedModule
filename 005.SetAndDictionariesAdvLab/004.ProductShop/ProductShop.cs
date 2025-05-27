//Set and dictionaries advanced - lab, Task 004
//27.05.2025, 01:10

public class ProductShop
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
        
        while(true)
        {
            string[] input = Console.ReadLine().Split(", ");

            if(input[0] == "Revision")
            {
                break;
            }

            string shop = input[0];
            string product = input[1];
            double price = double.Parse(input[2]);

            if(!shops.ContainsKey(shop))
            {
                shops[shop] = new Dictionary<string, double>();
            }

            if(!shops[shop].ContainsKey(product))
            {
                shops[shop][product] = price;
            }

            shops[shop][product] = price;
        }

        PrintShops(shops);
    }

    static void PrintShops(Dictionary<string, Dictionary<string, double>> shopList)
    {
        foreach(var item in shopList)
        {
            string shops = item.Key;
            var products = item.Value;

            Console.Write(item.Key + " ");

            foreach(var product in products.Keys)
            {
                Console.Write(product + " ");
            }
        }
    }
}