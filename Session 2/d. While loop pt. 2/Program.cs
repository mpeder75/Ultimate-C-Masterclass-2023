
Console.WriteLine("Enter word: ");
var userInput = Console.ReadLine();

// condition tjekker om længden af ordet er mindre end 15 bogstaver
// HVIS condition valideres til true, lægges bogstave 'a' til userInput

while(userInput.Length < 15) {
    userInput += 'a';
    Console.WriteLine("Word is now: " + userInput);
}

    
Console.WriteLine("Press any key to exit");
Console.ReadKey();