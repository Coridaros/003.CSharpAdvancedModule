//Exam preparation - 2022, Task 002
//17.06.2025, 21:38

public class TruffleHunter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[,] matrix = new char[n, n];

        int cntBlac = 0;
        int cntWhite = 0;
        int cntSummer = 0;
        int eaten = 0;

        for(int i = 0; i < n; i++)
        {
            char[] input = Console.ReadLine().Replace(" ", "").ToCharArray();

            for(int j = 0; j < n; j++)
            {
                matrix[i, j] = input[j];
            }
        }

        string command = Console.ReadLine();

        while(command != "Stop the hunt")
        {
            string cmdName = command.Split()[0];
            int row = int.Parse(command.Split()[1]);
            int col = int.Parse(command.Split()[2]);

            if(cmdName == "Collect")
            {
                char truffel = matrix[row, col];
                matrix[row, col] = '-';

                if(truffel == 'B')
                {
                    cntBlac++;
                }
                else if(truffel == 'W')
                {
                    cntWhite++;
                }
                else if(truffel == 'S')
                {
                    cntSummer++;
                }
            }
            else if(cmdName == "Wild_Boar")
            {
                string direction = command.Split()[3];

                if(direction == "up")
                {
                    while(IsValidRow(row, n))
                    {
                        if(EatBoar(row, col, matrix))
                        {
                            eaten++;
                        }

                        row -= 2;
                    }
                }
                else if(direction == "down")
                {
                    while (IsValidRow(row, n))
                    {
                        if (EatBoar(row, col, matrix))
                        {
                            eaten++;
                        }

                        row += 2;
                    }
                }
                else if(direction == "left")
                {
                    while (IsValidCol(col, n))
                    {
                        if (EatBoar(row, col, matrix))
                        {
                            eaten++;
                        }

                        col -= 2;
                    }
                }
                else if (direction == "right")
                {
                    while (IsValidCol(col, n))
                    {
                        if (EatBoar(row, col, matrix))
                        {
                            eaten++;
                        }

                        col += 2;
                    }
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"Peter manages to harvest {cntBlac} black, {cntSummer} summer, and {cntWhite} white truffles.");
        Console.WriteLine($"The wild boar has eaten {eaten} truffles.");

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static bool IsValidRow(int row, int size)
    {
        return row >= 0 && row < size;
    }

    public static bool IsValidCol(int col, int size)
    {
        return col >= 0 && col < size;
    }

    public static bool EatBoar(int row, int col, char[,] matrix)
    {
        char currSymbol = matrix[row, col];

        if(currSymbol == 'B' || currSymbol == 'W' || currSymbol == 'S')
        {
            matrix[row, col] = '-';
            return true;
        }

        return false;
    }
}