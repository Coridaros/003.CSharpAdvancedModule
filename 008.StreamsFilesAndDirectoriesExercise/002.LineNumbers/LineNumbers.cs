//Streams, files and directories - exercise, Task 002
//09.06.2025, 23:53

namespace LineNumbers;

public class LineNumbers
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";
        string outputFilePath = @"..\..\..\output.txt";

        ProcessLines(inputFilePath, outputFilePath);
    }

    public static void ProcessLines(string inputFilePath, string outputFilePath)
    {
        int cnt = 0;
        string[] text = File.ReadAllLines(inputFilePath);
        List<string> strings = new List<string>();

        foreach(var line in text)
        {
            cnt++;
            int cntLetters = line.Count(char.IsLetter);
            int cntPuct = line.Count(char.IsPunctuation);

            string modLine = "Line " + cnt + ": " + line + " (" + cntLetters + ")" + "(" + cntPuct + ")";

            strings.Add(modLine);
        }

        File.WriteAllLines(outputFilePath, strings);
    }
}