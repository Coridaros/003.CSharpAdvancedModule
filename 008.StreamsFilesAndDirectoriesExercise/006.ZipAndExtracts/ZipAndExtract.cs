//Streams, files and directories - exercise, Task 006
//10.06.2025, 00:25

using System.IO.Compression;

namespace ZipAndExtract;

public class ZipAndExtract
{
    static void Main()
    {
        string inputFile = @"..\..\..\copyMe.png";
        string zipArchiveFile = @"..\..\..\archive.zip";
        string extractedFile = @"..\..\..\extracted.png";

        ZipFileToArchive(inputFile, zipArchiveFile);

        var fileNameOnly = Path.GetFileName(inputFile);
        ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
    }

    public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
    {
        var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);

        using(archive)
        {
            //1. вземаме файла
            string fileName = Path.GetFileName(inputFilePath);

            //2. създаваме zipa
            archive.CreateEntryFromFile(inputFilePath, fileName);
        }
    }

    public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
    {
        var archive = ZipFile.OpenRead(zipArchiveFilePath);

        using(archive)
        {
            var fileToExtract = archive.CreateEntry(fileName);
            fileToExtract.ExtractToFile(outputFilePath);
        }
    }
}