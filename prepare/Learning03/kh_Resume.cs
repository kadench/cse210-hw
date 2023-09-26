using System;
public class Kh_resume
{
    public string _khName = ""; 
    public List<Kh_job> _khJobs = new List<Kh_job>();

    public void KhDisplayResume()
    {
        Console.WriteLine($"Name: {_khName}:");
        Console.WriteLine("Jobs:");
        foreach (Kh_job job in _khJobs)
        {
            job.KhDisplayJobDetails();
        }
    }
}