
// 1. opretter instans af DateTime som gemmes i variablen "internationalPizzaDay"
var internationalPizzaDay2023 = new DateTime(2023, 2, 9);


// Her printes .Year .Month .Day  
Console.WriteLine($"Year is : {internationalPizzaDay2023.Year}");
Console.WriteLine($"Month is : {internationalPizzaDay2023.Month}");
Console.WriteLine($"Day is : {internationalPizzaDay2023.Day}");


// Her prints datoens ugenavn
Console.WriteLine($"Day of week is : {internationalPizzaDay2023.DayOfWeek}");

// Her printes ugenummeret dom datoen tilhøre - Uge: 40
Console.WriteLine($"Day of week is : {internationalPizzaDay2023.DayOfYear}");


// Her oprettes et objekt/instans der repræsentere dagen, MEN et år frem
var internationalPizzaDay2024 = internationalPizzaDay2023.AddYears(1);
Console.WriteLine($"internationalPizzaDay2024 is held : {internationalPizzaDay2024} ");


// Udskriv en instans af dags dato
var myTime = DateTime.Now;
Console.WriteLine(myTime);


// Udskriv en instans af dags dato UDEN klokkeslet
var myTime2 = DateTime.Now;
Console.WriteLine(myTime.ToString("dd/MM/yyyy"));





