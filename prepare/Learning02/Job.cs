using System;

//This is the class for Job
public class Job
{
    //
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    //
    public Job ()
    {
    }
    public void Display()
    {
        Console.WriteLine($"Job: {_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


}

