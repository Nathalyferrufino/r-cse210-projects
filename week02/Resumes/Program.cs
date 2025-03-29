using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2021;
        
        Job job2 = new Job();
        job2._company = "Meta";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2021;
        job2._endYear = 2024;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume myResume = new Resume ();
        myResume._name = "Nathaly Ferrufino";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

    }
}