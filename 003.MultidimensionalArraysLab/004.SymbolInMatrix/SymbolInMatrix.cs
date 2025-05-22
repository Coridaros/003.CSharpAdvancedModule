//Multidimensional arrays - lab, Task 004
//22.05.2025, 23:22

int size = int.Parse(Console.ReadLine());

char[,] matrix = new char[size, size];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    char[] symbols = Console.ReadLine().ToCharArray();

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = symbols[j];
    }
}

char symbol = char.Parse(Console.ReadLine());

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        if(matrix[i, j] == symbol)
        {
            Console.WriteLine($"({i}, {j})");
            return;
        }
    }
}

Console.WriteLine($"{symbol} does not occur in the matrix");



