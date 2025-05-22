//Multidimensional arrays - lab, Task 005
//22.05.2025, 23:53

int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int bestRow = 0;
int bestCol = 0;
int sum = int.MinValue;
int[,] matrix = new int[size[0], size[1]];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = numbers[j];
    }
}

for(int i = 0; i < matrix.GetLength(0) - 1; i++)
{
    for(int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        if(matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1] > sum)
        {
            sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
            bestRow = i;
            bestCol = j;
        }
    }
}

Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]}");
Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]}");
Console.WriteLine(sum);