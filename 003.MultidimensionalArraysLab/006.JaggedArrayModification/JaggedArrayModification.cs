//Multidimensional arrays - lab, Task 006
//23.05.2025, 00:29

int size = int.Parse(Console.ReadLine());

int[][] jArray = new int[size][];

for(int i = 0; i < jArray.Length; i++)
{
    jArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

while(true)
{
    string[] inputData = Console.ReadLine().Split().ToArray();

    string cmd = inputData[0];


    if(cmd == "END")
    {
        break;
    }

    int row = int.Parse(inputData[1]);
    int col = int.Parse(inputData[2]);
    int val = int.Parse(inputData[3]);

    if (row >= 0 && row < jArray.Length && col >= 0 && col < jArray[row].Length)
    {
        if (cmd == "Add")
        {
            jArray[row][col] += val;
        }
        else if (cmd == "Subtract")
        {
            jArray[row][col] -= val;
        }
    }
    else
    {
        Console.WriteLine("Invalid coordinates");
    }
}

foreach(var element in jArray)
{
    Console.WriteLine(string.Join(" ", element));
}