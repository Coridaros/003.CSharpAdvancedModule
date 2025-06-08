//Streams, files and directories - lab, Task 006
//07.06.2025, 02:08

namespace SplitMergeBinaryFile;

public class SplitMergeBinaryFile
{
    static void Main()
    {
        string sourceFilePath = @"..\..\..\Files\example.png";
        string joinedFilePath = @"..\..\..\Files\example-joined.png";
        string partOnePath = @"..\..\..\Files\part-1.bin";
        string partTwoPath = @"..\..\..\Files\part-2.bin";

        SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
        MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
    }

    public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
    {
        byte[] inputData = File.ReadAllBytes(sourceFilePath);
        int fileSize = inputData.Length;

        int partOneSize = (fileSize + 1) / 2;
        int partTwoSize = fileSize / 2;

        File.WriteAllBytes(partOneFilePath, inputData[..partOneSize]);
        File.WriteAllBytes(partTwoFilePath, inputData[partTwoSize..]);
    }

    public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
    {
        byte[] part1Data = File.ReadAllBytes(partOneFilePath);
        byte[] part2Data = File.ReadAllBytes(partTwoFilePath);
        byte[] mergedData = new byte[part1Data.Length + part2Data.Length];

        part1Data.CopyTo(mergedData, 0);
        part2Data.CopyTo(mergedData, part1Data.Length);

        File.WriteAllBytes(joinedFilePath, mergedData);
    }
}