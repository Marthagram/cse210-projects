public class Job
{
    public string _company = "";
    public string _jobTittle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTittle} ({_company}) {_startYear}-{_endYear}");
    }
}