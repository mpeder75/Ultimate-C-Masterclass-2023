Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

/*
    explicitly typed boolean:  ->   bool someBoolean = true;

    implicitly typed boolean:  ->   var someOtherBoolean = false;
*/


/* ----- Declare boolean ------ */
// Her declares en boolean variabel isUserInputABC, som returner true hvis bruger input er ABC, eller false hvis det er alt anet 
bool isUserInputAbc = userChoice == "ABC";


/* ----- NOT operator ------ */
bool isUserInputNotAbc1 = userChoice != "ABC";

// ELLER
bool isUserInputNotAbc2 = !(userChoice == "ABC");


/* ----- Comparison operator ------ */
var number = 10;

var isLargerThan5 = number > 5;             // større end 5
var isSmallerThan5 = number < 5;            // mindre end 5
var isLargerOrEqualto10 = number >= 10;     // større eller lig med 10
var isSmallerOrEqualto6 = number <= 6;      // mindre eller lig med 6

/* ----- Modulo operator ------ */
var is10Mod3EqualTo1 = 10 % 3 == 1;

var isEven = 10 % 2 == 0;

Console.ReadKey();