
using System.ComponentModel.DataAnnotations;

public class Job
{
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;
    
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    public void SetInfo(string _jobTitle, string _company, int _startYear, int _endYear)
    {
        this._startYear = _startYear;
        this._endYear = _endYear;
        this._company = _company;
        this._jobTitle = _jobTitle;
    }
}

