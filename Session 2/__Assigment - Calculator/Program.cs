Console.WriteLine("Hello!");

// Bruger indtaster første tal, der gemmes som string input1 som derefter parses til en int kaldt num1
Console.WriteLine("Input first number");
var input1 = Console.ReadLine(); 
var num1 = int.Parse(input1);

// Bruger indtaster andet tal, der gemmes som string input2 som derefter parses til en int kaldt num2
Console.WriteLine("Input second number");
var input2 = Console.ReadLine();
var num2 = int.Parse(input2);

// Her skal bruger vælge hvad der skal ske med de to indtastede tal, valg A,B,C gemmes i userChoice
Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd the numbers");
Console.WriteLine("[S]ubtract the numbers");
Console.WriteLine("[M]ultiply the numbers");
var userChoice = Console.ReadLine();

// Hvis bruger indtaster A,B,C kaldes Addition method, Subtraction method, Multiplication method
if (userChoice == "A" || userChoice == "a") {
    int add = Addition(num1, num2);
    Console.WriteLine(add);
} else if (userChoice == "S" || userChoice == "s") {
    int sub = Subtraction(num1, num2);
    Console.WriteLine(sub);
} else if (userChoice == "M" || userChoice == "m") {
    int mult = Multiplication(num1, num2);
    Console.WriteLine(mult);
} else {
    Console.WriteLine("Invalid option");
}

// Når tal er manipuleret af methods, bedes bruger lave et keyboard input, for at lukke programmet    
Console.WriteLine("Press any key to exit");
Console.ReadKey();

/* ------- Methods ------- */

int Addition(int a, int b) {
    Console.WriteLine(num1 + " + " + num2 + " is: ");
    return a + b;
}

int Subtraction(int a, int b) {
    Console.WriteLine(num1 + " - " + num2 + " is: ");
    return a - b;
}

int Multiplication(int a, int b) {
    Console.WriteLine(num1 + " * " + num2 + " is: ");
    return a * b;
}




