//Multidimensional arrays - lab, Task 007
//23.05.2025, 01:45

int n = int.Parse(Console.ReadLine());

long[][] pascalTriangle = new long[n][];

for(int i = 0; i < n; i++)
{
    pascalTriangle[i] = new long[i + 1];
    pascalTriangle[i][0] = 1;

    for(int j = 1; j < i; j++)
    {
        pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
    }

    pascalTriangle[i][i] = 1;
}

for(int i = 0; i < pascalTriangle.Length; i++)
{
    Console.WriteLine(string.Join(" ", pascalTriangle[i]));
}