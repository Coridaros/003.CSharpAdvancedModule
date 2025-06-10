//Streams, files and directories - exercise, Task 001
//09.06.2025, 22:48

using System.Diagnostics;
using System.Text;

namespace EvenLines;

public class EvenLines
{
    static void Main()
    {
        string inputFile = @"../../../text.txt";

        Console.WriteLine(ProcessLines(inputFile));

        //ProcessLines(inputFile);
    }

    public static string ProcessLines(string inputFile)
    {
        int cnt = 0;
        StringBuilder sb = new StringBuilder();
        StreamReader reader = new StreamReader(inputFile);

        using(reader)
        {
            while(true)
            {
                string line = reader.ReadLine();

                if(line == null)
                {
                    break;
                }

                line = ReplaceSymbol(line);
                line = ReverseStr(line);

                if(cnt % 2 == 0)
                {
                    sb.AppendLine(line);
                }

                cnt++;
            }
        }

        return sb.ToString();
    }

    private static string ReplaceSymbol(string text)
    {
        string mod = text.Replace('-', '@').Replace(',', '@').Replace('.', '@').Replace('!', '@').Replace('!', '@');
        return mod;
    }

    private static string ReverseStr(string str)
    {
        return string.Join("", str.Reverse());
    }
}