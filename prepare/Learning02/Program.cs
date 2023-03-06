using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "EA Sports";
        job1._startYear = 2011;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Ceo";
        job2._company = "Topside";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume resume1 = new Resume();
        resume1._name = "Joaquin Leiva";
        
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}