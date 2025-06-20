﻿//Streams, files and directories - exercise, Task 004
//10.06.2025, 00:57

using System.Text;

namespace DirectoryTraversal;

public class DirectoryTraversal
{
    static void Main()
    {
        string path = Console.ReadLine();
        string reportFileName = @"\report.txt";

        string reportContent = TraverseDirectory(path);
        Console.WriteLine(reportContent);

        WriteReportToDesktop(reportContent, reportFileName);
    }

    public static string TraverseDirectory(string inputFolderPath)
    {
        SortedDictionary<string, List<FileInfo>> extension = new SortedDictionary<string, List<FileInfo>>();

        string[] files = Directory.GetFiles(inputFolderPath);

        foreach (var file in files)
        {
            FileInfo fileInfo = new FileInfo(file);

            if (!extension.ContainsKey(fileInfo.Extension))
            {
                extension.Add(fileInfo.Extension, new List<FileInfo>());
            }

            extension[fileInfo.Extension].Add(fileInfo);
        }

        var orderedFiles = extension.OrderByDescending(f => f.Value.Count);

        var stringBuilder = new StringBuilder();

        foreach (var file in orderedFiles)
        {
            stringBuilder.AppendLine(file.Key);

            var ordered = file.Value.OrderByDescending(f => f.Length);

            foreach (var currentFile in ordered)
            {
                stringBuilder.AppendLine($"--{currentFile.Name} - {(double)currentFile.Length / 1024:f3}kb");
            }
        }

        return stringBuilder.ToString();
    }

    public static void WriteReportToDesktop(string textContent, string reportFileName)
    {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

        File.WriteAllText(filePath, textContent);
    }
}
