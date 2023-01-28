using System;
//This is the Resume Class

public class Resume 
{
    // This is the Member variable (atribute) for the person's name
    public string _name = "";

    //This is the member variable for the list jobs
    
    public List<Job> _jobs = new List<Job>();

    //Displaying the member variables
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs) 
        {
            job.Display();
        }
    }

}