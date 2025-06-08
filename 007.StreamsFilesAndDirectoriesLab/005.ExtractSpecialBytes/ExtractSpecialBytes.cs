//Streams, files and directories - lab, Task 005
//06.06.2025, 23:46

namespace ExtractSpecialBytes;

public class ExtractSpecialBytes
{
    static void Main()
    {
        string binaryFilePath = @"..\..\..\Files\example.png";
        string bytesFilePath = @"..\..\..\Files\bytes.txt";
        string outputPath = @"..\..\..\Files\output.bin";

        ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);

    }

    public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
    {
        HashSet<byte> targetB = new HashSet<byte>(File.ReadAllLines(bytesFilePath)
            .Select(l => byte.Parse(l.Trim())));

        byte[] input = File.ReadAllBytes(binaryFilePath);
        byte[] filteredData = input.Where(b => targetB.Contains(b)).ToArray();

        File.WriteAllBytes(outputPath, filteredData);
    }
}