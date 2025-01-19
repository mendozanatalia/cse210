using System;

class Program
{
    static void Main(string[] args)
    {
        // Create new job variables
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Apple";
        job2._startYear = 2014;
        job2._endYear = 2020;

        // Call Resume class to asign a name
        Resume myResume = new Resume();
        myResume._name = "Natalia Mendoza";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}