//Set and dictionaries advanced - lab, Task 002
//27.05.2025, 00:15

public class AverageStudentGrades
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, List<decimal>> studentInfo = new Dictionary<string, List<decimal>>();

        for(int i = 0; i < n; i++)
        {
            string[] inputData = Console.ReadLine().Split();
            string studentName = inputData[0];
            decimal grade = decimal.Parse(inputData[1]);

            //ако студента не съществува в речника го добавяме и създаваме нов списък с оценки към него
            if(!studentInfo.ContainsKey(studentName))
            {
                studentInfo[studentName] = new List<decimal>();
            }

            //добавяме към списъка на студента оценки
            studentInfo[studentName].Add(grade);
        }

        PrintStudentGrades(studentInfo);
    }

    static void PrintStudentGrades(Dictionary<string, List<decimal>> studentsInfo)
    {
        foreach(var item in studentsInfo)
        {
            var grades = item.Value;
            decimal avg = grades.Average();

            Console.Write($"{item.Key} -> ");

            foreach(var grade in grades)
            {
                Console.Write($"{grade:F2} ");
            }

            Console.WriteLine($"(avg: {avg:F2})");
        }
    }
}