
Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();


/* ------- If Statement ------- */

// HVIS bruger indtaster ABC, bliver der printet 'User typed ABC' ELLERS printes 'User did not print ABC'

if (userChoice == "ABC" ) {
    Console.WriteLine("User typed ABC");
} else {
    Console.WriteLine("User did not type ABC");  
}

/* HVIS længden af input er mindre eller lig med 3, printes 'Short answer'
   ELLERS HVIS længden er mindre end 10 printes 'Medium answer'
   ELLERS printes 'Long answer' */

if (userChoice.Length <= 3) {
    Console.WriteLine("Short answer");
} else if (userChoice.Length < 10) {
    Console.WriteLine("Medium Answer");
} else  {
    Console.WriteLine("Long answer");
}


