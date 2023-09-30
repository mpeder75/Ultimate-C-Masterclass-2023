
var medicalAppointment = new MedicalAppointment("John Smith", new DateTime(2022, 1, 2)); 


class medicalAppointment
{
    private string _paitentName;
    private DateTime _date;

    public medicalAppointment(string paitentName, DateTime date)
    {
        _paitentName = paitentName;
        _date = date;
    }

    // method
    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    // Method overloading, samme navn men har forskellige parametre
    public void Reschedule(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    /* Denne vil IKKE virke da den første overloaded method har samme parametre...
    public void Reschedule(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    }
    */

}

