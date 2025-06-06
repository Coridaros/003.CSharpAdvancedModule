//Streams, files and directories - lab, Task 002
//04.06.2025, 23:44

namespace LineNumbers;

public class LineNumbers
{
    static void Main()
    {
        string inputFile = @"../../../Files/input.txt";
        string outputFile = @"../../../Files/output.txt";

        RewriteFileWithLineNumbers(inputFile, outputFile);
    }

    public static void RewriteFileWithLineNumbers(string inputFile, string outputFile)
    {
        int cnt = 1;
        StreamReader reader = new StreamReader(inputFile);
        StreamWriter writer = new StreamWriter(outputFile);

        using (reader)
        {
            string line = reader.ReadLine();

            using(writer)
            {
                while (line != null)
                {
                    writer.WriteLine($"{cnt}. {line}");
                    cnt++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
