Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

var number = 10;

/* AND operator - BEGGE skal være true, for at hele statement er true */
// Der tjekkes om number er større end 4 og mindre end 9 
var myBool1 = number > 4 && number < 9;


/* OR operator - BLOT EN skal være true, for at hele statement er true */
// Der tjekkes om number er lig med 2 ELLER number er større end 6
var myBool2 = number == 2 || number > 6;


/* AND samt OR operator - AND og OR bruges sammen  */
var myBool3 = number == 123 || (number % 2 == 0 && number < 20);


Console.ReadKey();