

var userChoice = Console.ReadLine();        // Global variabel kan bruges i ALT


if (userChoice.Length == 0) 
{                                           // Code bracket gør at koder heri er lokal scope        
    Console.WriteLine("Empty choice!");
    int number = 5;                         // Lokal variabel number kan KUN bruges i denne code block
    Console.WriteLine(number);  
} else {
    Console.WriteLine("Non-empty: " + userChoice);
}

Console.WriteLine("Your choice is: " + userChoice);



