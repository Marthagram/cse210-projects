using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTittle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2022;
        
        

        Job job2 = new Job();
        job2._company ="Apple";
        job2._jobTittle = "Game Developer";
        job2._startYear = 2017;
        job2._endYear = 2024;
       

        Resume resume = new Resume();
        resume._name = "Martha Itohan Otasowie";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
        

    }
}