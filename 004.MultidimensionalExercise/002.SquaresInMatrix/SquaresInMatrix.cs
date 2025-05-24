//Multidimensional arrays - exercise, Task 002
//23.05.2025, 21:15

public class SquaresInMatrix
{
    static void Main()
    {
        string size = Console.ReadLine();
        int rows = int.Parse(size.Split()[0]); // вземаме редовете
        int cols = int.Parse(size.Split()[1]); // вземаме колоните

        int count = 0;
        string[,] matrix = new string[rows, cols];

        ReadMatrix(matrix);

        for(int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for(int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                // проверяваме за матрица 2х2
                if(matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1])
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }

    static void ReadMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] inputData = Console.ReadLine().Split().ToArray();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = inputData[j];
            }
        }
    }
}