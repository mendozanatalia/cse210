using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Natalia Mendoza", "The Creation of Arcane");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Camilo Caillavy", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Marcelo Revollo", "Bolivian History", "The Causes of Independency");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}