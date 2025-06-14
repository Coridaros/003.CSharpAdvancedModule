﻿//Streams, files and directories - exercise
//10.06.2025, 00:52

namespace CopyDirectory;

public class CopyDirectory
{
    static void Main()
    {
        string inputPath = @$"{Console.ReadLine()}";
        string outputPath = @$"{Console.ReadLine()}";

        CopyAllFiles(inputPath, outputPath);
    }

    public static void CopyAllFiles(string inputPath, string outputPath)
    {
        if (Directory.Exists(outputPath))
        {
            Directory.Delete(outputPath);
        }

        Directory.CreateDirectory(outputPath);

        string[] files = Directory.GetFiles(inputPath);

        foreach (var file in files)
        {
            string currentFile = Path.GetFileName(file);

            string dir = Path.Combine(outputPath, currentFile);

            File.Copy(currentFile, dir);
        }
    }
}