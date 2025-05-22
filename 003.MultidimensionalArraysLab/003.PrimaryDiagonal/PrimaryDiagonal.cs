//Multidimensional arrays - lab, Task 003
//22.05.2025, 23:09

int size = int.Parse(Console.ReadLine());

int sum = 0;
int[,] matrix = new int[size, size];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = numbers[j];
    }
}

for(int i = 0; i < matrix.GetLength(0); i++)
{
    //Option 1
    //for(int j = i; j <= i; j++)
    //{
    //    sum += matrix[i, j];
    //}

    //Option 2
    sum += matrix[i, i];
}

Console.WriteLine(sum);