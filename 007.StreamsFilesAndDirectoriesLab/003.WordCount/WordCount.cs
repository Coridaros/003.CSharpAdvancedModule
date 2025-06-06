//Streams, files and directories - lab, Task 003
//06.06.2025, 21:49

namespace WordCount;

public class WordCount
{
    static void Main()
    {
        string wordPath = @"../../../Files/words.txt";
        string textPath = @"../../../Files/text.txt";
        string outputPath = @"../../../Files/output.txt";

        CalculateWordCounts(wordPath, textPath, outputPath);
    }

    public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFile)
    {
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        StreamReader reader = new StreamReader(wordsFilePath);
        string[] words;
        string[] cntWords;

        using(reader)
        {
            string line = reader.ReadToEnd().ToLower();

            words = line.Split(" ");
        }

        StreamReader readerTwo = new StreamReader(textFilePath);

        using(readerTwo)
        {
            string line = readerTwo.ReadToEnd().ToLower();

            cntWords = line.Replace("-", " ")
                .Replace(",", " ")
                .Replace(".", " ")
                .Replace("!", " ")
                .Replace("?", " ")
                .Replace("...", " ")
                .Replace("\r\n", " ").Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }

        foreach(var word in words)
        {
            foreach(var cntWord in cntWords)
            {
                if(word == cntWord)
                {
                    if(!wordCounts.ContainsKey(word))
                    {
                        wordCounts.Add(word, 1);
                    }
                    else
                    {
                        wordCounts[word]++;
                    }
                }
            }
        }

        var sortedDict = wordCounts.OrderBy(x => -x.Value);

        StreamWriter writer = new StreamWriter(outputFile);

        using(writer)
        {
            foreach (var item in sortedDict)
            {
                writer.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
