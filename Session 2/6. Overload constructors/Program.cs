/*todo
Constructor overloading: 
når der er flere constructors med samme navn, der har forskellige parametre 

constructor overloading KRÆVER at hver constructor, med samme navn, 
har forskellige parametre
*/


class medicalAppointment
{
    private string _patientName;
    private DateTime _date;
    
    // counstructor 1
    public medicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    // constructor 2 - er overlaoded, samme navn, men med andre parametre
    public medicalAppointment(string patientName)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(7);
    }

    // constructor 3 - er overloaded, samme navn, men med andre parametre
    public medicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }


    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    public void Reschedule(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    
}

