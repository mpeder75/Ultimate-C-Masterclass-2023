/*
Using string interpolation, implement the FormatDate method, 
which given three integers representing the year, 
month and day shall return a string in the format YEAR/MONTH/DAY.

For example:
 - for the year 2022, month 10, and day 29, it shall return "2022/10/29"
 - for the year 1911, month 1, and day 5, it shall return "1911/1/5"
*/



Console.WriteLine("Enter year: ");
var input1 = Console.ReadLine();
var year = int.Parse(input1);

Console.WriteLine("Enter month: ");
var input2 = Console.ReadLine();
var month = int.Parse(input2);

Console.WriteLine("Enter day: ");
var input3 = Console.ReadLine();
var day = int.Parse(input3);


FormatDate(year, month, day);



void FormatDate(int y, int m, int d) {
    
  Console.WriteLine($"{y}/{m}/{d}");
}

Console.WriteLine("Press a key to exit..");
Console.ReadKey();