/*

void Methods er methods der IKKE returnere

Methods bruges når man har kode der oftest gentages

Tænk på methods som et underprogram, eller en funktion 

*/

Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

// Hvis bruger input er A - vil PrintSelectedOption kaldes med argument
if (userChoice == "S") {
    PrintSelectedOption("See all TODOS"); 
} else if (userChoice == "A") {
    PrintSelectedOption("Add a TODO");
} else if (userChoice == "R") {
    Console.WriteLine("Remove TODO");
} else if (userChoice == "E") {
    Console.WriteLine("Exit");
}


// method der printer "Selected option" samt det selectedOption der er passed til method (S, A, R, E)
void PrintSelectedOption(string selectedOption) 
{
    Console.WriteLine("Selected option: " + selectedOption);
}

Console.ReadLine();

