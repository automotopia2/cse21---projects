using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1.SetInfo("Lead Engineer", "Tesla", 2002, 2026);
        // job1.Display();

        Job job2 = new Job();

        job2.SetInfo("Software Engineer,", "Microsoft", 2006, 2007);

        Resume resume = new Resume();

        resume.AddJob(job1);
        resume.AddJob(job2);

        resume.SetName("Joshua");

        resume.Display();

    }
}