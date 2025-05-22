//Miltidimensional arrays - lab, Task 001
//22.05.2025, 22:37

int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int sum = 0;
int rows = dimensions[0];
int cols = dimensions[1];
int[,] matrix = new int[rows, cols];

//Read the matrix
for(int i = 0; i < matrix.GetLength(0); i++)
{
    int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        //Init matrix values
        matrix[i, j] = row[j];
    }
}

//Calculate the sum
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
}

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);