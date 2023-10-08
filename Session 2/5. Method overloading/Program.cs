/*todo
Method overloading = er når man har flere methods med samme navn

Method overloading kræver at hver metod med samme navn, har forskellige parametre
*/


var medicalAppointment = new MedicalAppointment("John Smith", new DateTime(2022, 1, 2)); 


class medicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public medicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
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

    /*!  Method der fjerne er scheldue
         Denne vil IKKE VIRKE da den har samme parametre som første  overloaded method */
    /*
    public void Reschedule(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    }
    */

 }

