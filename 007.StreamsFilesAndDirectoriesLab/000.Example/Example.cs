//Streams, files and directories - lab, Exaple
//04.06.2025, 22:50

public class Example
{
    static void Main()
    {
        string inputFile = "../../../input.txt";

        StreamReader reader = new StreamReader(inputFile);

        ConPlay();

        using(reader)
        {
            int cnt = 1;

            while(true)
            {
                string line = reader.ReadLine();

                if(line == null)
                {
                    break;
                }

                Console.WriteLine($"{cnt}. {line}");

                cnt++;
            }
        }

        static void ConPlay()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Example";
        }
    }
}