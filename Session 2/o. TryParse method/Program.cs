
// TryParse med out parameter
/*
Console.WriteLine("Enter a number");
var userInput = Console.ReadLine();

bool isParsingSuccesful = int.TryParse(userInput, out int number);

if (isParsingSuccesful)
{
    Console.WriteLine("Paresing worked, numeber is: " + number);
}
else
{
    Console.WriteLine("Parsing NOT succesful");
}

*/

// Eksempel: Få bruger til at inputte valid input

bool isParsingSuccesful;

do
{
    Console.WriteLine("Enter a number");
    var userInput = Console.ReadLine();

    isParsingSuccesful = int.TryParse(userInput, out int number);
    if (isParsingSuccesful)
    {
        Console.WriteLine("Parsing worked, number is: " + number);
    }
    else
    {
        Console.WriteLine("Not parsed correct");
    }
} while (!isParsingSuccesful);

var name;