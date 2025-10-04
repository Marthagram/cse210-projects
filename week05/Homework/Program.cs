using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asst1 = new Assignment("Jordan", "Algebra");
        Console.WriteLine(asst1.GetSummary());

        MathAssignment math1 = new MathAssignment("Gabbie", "Equation"," 4.2"," 4-5");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeWorkList());

        WritingAssignment write1 = new WritingAssignment("Janet", "Citizenship", "Civic Education in Africa");
        Console.WriteLine(write1.GetWritingInformation());

    }
}