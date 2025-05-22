//Multidimensional arrays - lab, Task 002
//22.05.2025, 22:56

int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int[,] matrix = new int[dimensions[0], dimensions[1]];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = numbers[j];
    }
}

for(int i = 0; i < matrix.GetLength(1); i++)
{
    int sum = 0;

    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        sum += matrix[j, i];
    }

    Console.WriteLine(sum);
}