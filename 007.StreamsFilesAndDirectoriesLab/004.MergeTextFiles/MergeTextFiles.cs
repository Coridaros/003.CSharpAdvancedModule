namespace MergeFiles;

public class MergeFiles
{
    static void Main()
    {
        var firstInputFilePath = @"..\..\..\Files\input1.txt";
        var secondInputFilePath = @"..\..\..\Files\input2.txt";
        var outputFilePath = @"..\..\..\Files\output.txt";

        MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
    }

    public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
    {
        Queue<string> firstFile = ReadToFile(firstInputFilePath);
        Queue<string> secondFile = ReadToFile(secondInputFilePath);
        StreamWriter writer = new StreamWriter(outputFilePath);

        int greater = Math.Max(firstFile.Count, secondFile.Count);

        using(writer)
        {
            for (int i = 0; i < greater; i++)
            {
                while(firstFile.Count > 0)
                {
                    writer.WriteLine(firstFile.Dequeue());
                }
                while(secondFile.Count > 0)
                {
                    writer.WriteLine(secondFile.Dequeue());
                }
            }
        }
    }

    static Queue<string> ReadToFile(string filePath)
    {
        Queue<string> queue = new Queue<string>();
        StreamReader reader = new StreamReader(filePath);

        using (reader)
        {
            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                queue.Enqueue(line);
            }
        }

        return queue;
    }
}
