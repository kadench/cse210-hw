// Creating the job class and defining the job class as public
public class Kh_job
{
    public string _kh_company = "";
    public string _kh_jobTitle = "";
    public int _kh_startYear = 0;
    public int _kh_endYear = 0;
    
    public void KhDisplayJobDetails()
    {
        Console.WriteLine($"{_kh_company} ({_kh_jobTitle}) {_kh_startYear}-{_kh_endYear}");
    }

}