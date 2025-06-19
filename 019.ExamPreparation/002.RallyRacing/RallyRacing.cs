//Exam preparation, Task 002
//19.06.2025, 01:20

public class RallyRacing
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string car = Console.ReadLine();

        char[,] matrix = new char[n, n];

        for(int i = 0; i < n; i++)
        {
            char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            for(int j = 0; j < n; j++)
            {
                matrix[i, j] = input[j];
            }
        }

        int carKm = 0;
        int carRow = 0;
        int carCol = 0;
        bool isFinished = false;

        

        while(true)
        {
            string command = Console.ReadLine();

            if(command == "End")
            {
                break;
            }

            if (command == "up")
            {
                carRow--;
            }
            else if(command == "down")
            {
                carRow++;
            }
            else if(command == "left")
            {
                carCol--;
            }
            else if(command == "right")
            {
                carCol++;
            }

            if(matrix[carRow, carCol] == '.')
            {
                carKm += 10;
                continue;
            }
            else
            {
                if(matrix[carRow, carCol] == 'T')
                {
                    matrix[carRow, carCol] = '.';
                    carKm += 30;
                    bool passed = false;

                    for(int i = 0; i < n; i++)
                    {
                        for(int j = 0; j < n; j++)
                        {
                            if(matrix[i, j] == 'T')
                            {
                                matrix[i, j] = '.';
                                passed = true;
                                carRow = i;
                                carCol = j;
                                break;
                            }
                        }

                        if(passed)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    isFinished = true;
                    carKm += 10;
                    break;
                }
            }
        }

        matrix[carRow, carCol] = 'C';

        if(isFinished)
        {
            Console.WriteLine($"Racing car {car} finished the stage!");
        }
        else
        {
            Console.WriteLine($"Racing car {car} DNF.");
        }

        Console.WriteLine($"Distance covered {carKm} km.");

        PrintMatrix(matrix);
    }

    static void PrintMatrix(char[,] matrix)
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