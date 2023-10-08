//todo .this keyword referen til nuværendne instans af en class

var medicalAppointment = new MedicalAppointment("John Smith", new DateTime(2023, 4, 3));

medicalAppointment.Reschedule(new DateTime(2023, 4, 4));

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

    public MedicalAppointment(string patientName)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(7);
    }

    public MedicalAppointment(string patientName, int daysFromNow)
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

