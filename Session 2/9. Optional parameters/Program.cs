//Todo Optional parameters bruges,
//Todo hvis man ikke er sikker på at de vil blive brugt


var appontmentTwoWeeksFromNow = new MedicalAppointment("Margret Smith");

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine("Appointment wil take place on" + medicalAppointment.GetDate());
    }
}


class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public DateTime GetDate() => _date;


    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

   /* public MedicalAppointment(string patientName) : this(patientName, 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(7);
    } */


    //! Her bruges optional parameter som er int daysFromNow = 7
    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }

    public void Reschedule(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }


}

