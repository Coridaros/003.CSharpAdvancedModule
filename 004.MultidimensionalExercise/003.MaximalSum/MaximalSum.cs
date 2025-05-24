//Multidimensional arrays - exercise, Task 003
//23.05.2025, 21:24

public class MaximalSum
{
    static void Main()
    {
        //четем размера на матрицата
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int col = 0;
        int row = 0;
        int bestSum = int.MinValue;
        int[,] matrix = new int[size[0], size[1]];

        ReadMatrix(matrix);

        for(int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for(int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                    + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                    + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    row = i;
                    col = j;
                }
            }
        }

        Console.WriteLine($"Sum = {bestSum}");
        Console.WriteLine($"{matrix[row, col]} {matrix[row, col + 1]} {matrix[row, col + 2]}");
        Console.WriteLine($"{matrix[row + 1, col]} {matrix[row + 1, col + 1]} {matrix[row + 1, col + 2]}");
        Console.WriteLine($"{matrix[row + 2, col]} {matrix[row + 2, col + 1]} {matrix[row + 2, col + 2]}");
    }

    static void ReadMatrix(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = inputData[j];
            }
        }
    }
}