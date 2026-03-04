using System.ComponentModel.DataAnnotations;

public class Resume
{
    private string _name;
    private List<Job> _jobs = new List<Job>();

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }
    public void SetName(string _name)
    {
        this._name = _name;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");
        for(int i = 0; i<_jobs.Count; i++)
        {
            _jobs[i].Display();
        }
    }



}