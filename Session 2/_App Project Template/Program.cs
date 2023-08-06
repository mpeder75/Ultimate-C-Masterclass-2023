Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

switch (userChoice) {
    case "s":
    case "S":
        PrintSelectedOption("See all TODOS");
        break;
    case "a":
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "r":
    case "R":
        Console.WriteLine("Remove TODO");
        break;
    case "e":
    case "E":
        Console.WriteLine("Exit");
        break;
    default:
        Console.WriteLine("Invalid value");
        break;
}


void PrintSelectedOption(string selectedOption) {
    Console.WriteLine("Selected option: " + selectedOption);
}


Console.WriteLine("Press key to exit...");
Console.ReadLine();