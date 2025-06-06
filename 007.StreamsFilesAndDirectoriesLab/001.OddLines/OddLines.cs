//Streams, files and directories - lab, Task 001
//04.06.2025, 22:46

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFile = @"../../../Files/input.txt";
            string outputFile = @"../../../Files/output.txt";

            ExtractOddLines(inputFile, outputFile);
        }

        public static void ExtractOddLines(string input, string output)
        {
            StreamReader reader = new StreamReader(input);
            StreamWriter writer = new StreamWriter(output);

            using (reader)
            {
                int cnt = 0;
                string line = reader.ReadLine();

                using (writer)
                {
                    while (line != null)
                    {
                        if (cnt % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }

                        cnt++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
