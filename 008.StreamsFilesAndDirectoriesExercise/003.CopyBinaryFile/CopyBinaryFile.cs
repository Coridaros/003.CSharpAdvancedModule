﻿//Streams, files and directories - exercise, Task 003
//10.06.2025, 00:59

namespace CopyBinaryFile;

public class CopyBinaryFile
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\copyMe.png";
        string outputFilePath = @"..\..\..\copyMe-copy.png";

        CopyFile(inputFilePath, outputFilePath);
    }

    public static void CopyFile(string inputFilePath, string outputFilePath)
    {
        using (var fileReader = new FileStream(inputFilePath, FileMode.Open))
        {
            using (var fileWriter = new FileStream(outputFilePath, FileMode.Create))
            {
                while (true)
                {
                    var buffer = new byte[264];

                    int bytesRead = fileReader.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        break;
                    }

                    fileWriter.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}
