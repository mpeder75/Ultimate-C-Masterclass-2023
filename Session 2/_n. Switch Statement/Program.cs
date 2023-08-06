/*
Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");


var userChoice = Console.ReadLine();

/* ----- Switch Statement ----- */

// Switch Statement kan bruges som et alternativ til If Statements

/*
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



if (userChoice == "S") {
    PrintSelectedOption("See all TODOS"); 
} else if (userChoice == "A") {
    PrintSelectedOption("Add a TODO");
} else if (userChoice =="R") {
    Console.WriteLine("Remove TODO");
} else if (userChoice == "E") {
    Console.WriteLine("Exit");
}
*/


/*
void PrintSelectedOption(string selectedOption) {
    Console.WriteLine("Selected option: " + selectedOption);
}

*/

/* ------ Switch Exercise ------ */

Console.WriteLine("Enter test point");
string testInput = Console.ReadLine();
int testPoints = int.Parse(testInput);

ConvertTestPointsToGrade(testPoints);

void ConvertTestPointsToGrade(int points) {
    switch (testPoints) {
        case 10:
        case 9:
            Console.WriteLine("Grade A");
            break;
        case 8:
        case 7:
        case 6:
            Console.WriteLine("Grade B");
            break;
        case 5:
        case 4:
        case 3:
            Console.WriteLine("Grade C");
            break;
        case 2:
        case 1:
            Console.WriteLine("Grade D");
            break;
        case 0:
            Console.WriteLine("Grade E");
            break;
        default:
            Console.WriteLine("!");
            break;
    }
}

Console.WriteLine("Press key to exit...");
Console.ReadLine();