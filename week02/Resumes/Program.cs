using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Process Engineer";
        job1._company = "Drury Industry Limited";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Production Manager";
        job2._company = "Anochemical Cosmetics Industries Limited";
        job2._startYear = 2014;
        job2._endYear = 2019;

        Resume myResume = new Resume();
        myResume._name = "Chisom Omeja";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}