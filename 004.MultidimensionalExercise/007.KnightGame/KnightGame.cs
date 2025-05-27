//Muldimensional arrays - exercise, Task 007
//26.05.2025, 19:24

using System.Runtime.CompilerServices;

public class KnightGame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int cnt = 0;
        bool checkForConf = true;
        bool[,] matrix = new bool[n, n];

        for(int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            for(int j = 0; j < n; j++)
            {
                matrix[i, j] = (input[j] == 'K');
            }
        }

        while(checkForConf)
        {
            int maxConf = 0;
            int maxConfRow = -1;
            int maxConfCol = -1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!matrix[i, j])
                    {
                        continue;
                    }

                    int conflicts = CountConf(matrix, i, j);

                    if(conflicts > maxConf)
                    {
                        maxConf = conflicts;
                        maxConfRow = i;
                        maxConfCol = j;
                    }
                }
            }

            if(maxConf == 0)
            {
                checkForConf = false;
            }
            else
            {
                matrix[maxConfRow, maxConfCol] = false;
                cnt++;
            }
        }

        Console.WriteLine(cnt);
    }

    static int[,] moves =
    {
        {1, 2},
        {1, -2},
        {-1, 2},
        {-1, -2},
        {2, 1},
        {2, -1},
        {-2, 1},
        {-2, -1}
    };

    static int CountConf(bool[,] matrix, int row, int col)
    {
        int count = 0;

        for(int i = 0; i < moves.GetLength(0); i++)
        {
            int nextRow = row + moves[i, 0];
            int nextCol = col + moves[i, 1];

            if(nextRow < 0 || nextRow >= matrix.GetLength(0) || nextCol < 0 || nextCol >= matrix.GetLength(1))
            {
                continue;
            }

            if(matrix[nextRow, nextCol])
            {
                count++;
            }
        }

        return count;
    }
}