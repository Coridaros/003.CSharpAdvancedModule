//Multidimensional arrays - exercise, Task 004
//23.05.2025, 23:07

public class MatrixShuffling
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[,] matrix = new int[size[0], size[1]];

        ReadMatrix(matrix);

        while(true)
        {
            string[] input = Console.ReadLine().Split();
            string command = input[0];

            if(command == "END")
            {
                break;
            }

            if(ValidateCommand(input, size[0], size[1]))
            {
                int row1 = int.Parse(input[1]);
                int col1 = int.Parse(input[2]);
                int row2 = int.Parse(input[3]);
                int col2 = int.Parse(input[4]);

                int firstElement = matrix[row1, col1];
                int secondElement = matrix[row2, col2];

                matrix[row1, col1] = secondElement;
                matrix[row2, col2] = firstElement;

                PrintMatrix(matrix);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
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

    static bool ValidateCommand(string[] str, int row, int col)
    {
        string cmd = str[0];
        
        if(cmd == "swap" && str.Length == 5)
        {
            int row1 = int.Parse(str[1]);
            int col1 = int.Parse(str[2]);
            int row2 = int.Parse(str[3]);
            int col2 = int.Parse(str[4]);

            if(row1 >= 0 && row1 < row && col >= 0 && col1 < col && row2 >= 00 && row2 < row && col2 >= 0 && col2 < col)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}