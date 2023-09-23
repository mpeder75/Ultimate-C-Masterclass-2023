
/* ------------ Printe linjer ------------- */
// Her printes at bruger skal indtaste: S, A, R, E
Console.WriteLine("Hello");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

/* ------------ Declare & Initialize variabler ------------- */
// Her declares userInput variabel af typen string, og assigns værdien "A", som bliver initialized  til sidst
string userInput = "A";

// userInput variable printes
Console.WriteLine(userInput);

// Her declares number variabel af typen int, og assigns værdien 2, som bliver initialized  til sidst
int number = 2;
// number variabel bliver reassigned til værdien 7
number = 7;


/* ------------ Declare & Initialize FLERE variabler på EEN gang ------------- */
int a = 1, B = 6;
string name, lastName;



/* ------------ Aflæse fra Keyboard ------------- */

// Her aflæses keyboard input og gemmes i variabel userChoice
string userChoice = Console.ReadLine();

// Her printes hvad bruger har inputtet
Console.WriteLine("User input: " + userChoice);

