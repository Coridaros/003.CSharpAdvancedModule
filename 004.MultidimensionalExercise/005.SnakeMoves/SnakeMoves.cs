//Multidimensional arrays - exercise, Task 005
//24.05.2025, 00:30

public class SnakeMoves
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string str = Console.ReadLine();

        string[,] matrix = new string[size[0], size[1]];

        int strLen = str.Length;
        int strIndex = 0;

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            if(i % 2 == 0)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    if (strIndex < strLen)
                    {
                        matrix[i, j] += str[strIndex];
                        strIndex++;
                    }
                    else
                    {
                        strIndex = 0;
                        j--;
                    }
                }
            }
            else
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    if (strIndex < strLen)
                    {
                        matrix[i, j] += str[strIndex];
                        strIndex++;
                    }
                    else
                    {
                        strIndex = 0;
                        j++;
                    }
                }
            }
        }

        PrintMatrix(matrix);
    }

    static void PrintMatrix(string[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }

            Console.WriteLine();
        }
    }
}