using System;

class Kh_program
{
    static void Main(string[] args)
    {
        // Making a the first instance of the job class
        Kh_job kh_job1 = new Kh_job();
        kh_job1._kh_jobTitle = "Software Engineer";
        kh_job1._kh_company = "Apple";
        kh_job1._kh_startYear = 2011;
        kh_job1._kh_endYear = 2019;
        kh_job1.KhDisplayJobDetails();

        // Second instance of job class
        Kh_job kh_job2 = new Kh_job();
        kh_job2._kh_jobTitle = "Game Developer";
        kh_job2._kh_company = "Epic Games";
        kh_job2._kh_startYear = 1992;
        kh_job2._kh_endYear = 2023;
        kh_job2.KhDisplayJobDetails();

        Kh_resume kh_resume1 = new Kh_resume();
        kh_resume1._khName = "John";
        kh_resume1._khJobs.Add(kh_job1);
        kh_resume1._khJobs.Add(kh_job2);
        kh_resume1.KhDisplayResume();
        

        



    }
}
