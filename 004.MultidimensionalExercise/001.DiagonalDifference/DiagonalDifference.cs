//Multidimensional arrays - exercise, Task 001
//23.05.2025, 20:45

public class DiagonalDifference
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int primarySum = 0;
        int secondarySum = 0;
        int[,] matrix = new int[n, n];

        ReadMatrix(matrix);

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                int currentNumber = matrix[i, j];

                if(i == j)
                {
                    primarySum += currentNumber;
                }

                if(i + j == n - 1)
                {
                    secondarySum += currentNumber;
                }
            }
        }

        Console.WriteLine(Math.Abs(primarySum - secondarySum));
    }

    static void ReadMatrix(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] inputData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = inputData[j];
            }
        }
    }
}