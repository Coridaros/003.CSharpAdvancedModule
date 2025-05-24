//Multidimensional arrays - exercise, Task 006
//24.05.2025, 01:17

public class JaggedArrayManipulator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] jArray = new int[n][];

        //четем масива от масиви
        for(int i = 0; i < jArray.Length; i++)
        {
            jArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        //анализираме
        for(int i = 0; i < n - 1; i++)
        {
            if(jArray[i].Length == jArray[i + 1].Length)
            {
                jArray[i] = jArray[i].Select(x => x * 2).ToArray();
                jArray[i + 1] = jArray[i + 1].Select(x => x * 2).ToArray();
            }
            else
            {
                jArray[i] = jArray[i].Select(x => x / 2).ToArray();
                jArray[i + 1] = jArray[i + 1].Select(x => x / 2).ToArray();
            }
        }

        while(true)
        {
            string[] inputData = Console.ReadLine().Split();

            string cmd = inputData[0];

            if(cmd == "End")
            {
                //принтираме на конзолата
                foreach (var element in jArray)
                {
                    Console.WriteLine(string.Join(" ", element));
                }

                break;
            }
            
            if(ValidateData(jArray, inputData))
            {
                int row = int.Parse(inputData[1]);
                int col = int.Parse(inputData[2]);
                int value = int.Parse(inputData[3]);

                if (cmd == "Add")
                {
                    jArray[row][col] += value;
                }
                else if(cmd == "Subtract")
                {
                    jArray[row][col] -= value;
                }
            }
        }
    }

    static bool ValidateData(int[][] jArray, string[] data)
    {
        int row = int.Parse(data[1]);
        int col = int.Parse(data[2]);

        if (row >= 0 && row < jArray.Length && col >= 0 && col < jArray[row].Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}