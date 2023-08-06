
Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

// Her kaldes AddMethod med argumenterne 10, 50, og resultatet gemmes i variablen result
var result = AddMethod(10, 50);


// Her kaldes IsLong method, der assigns det IsLong method returnere, når der passes userChoice
// det der returneres gemmes i boolean variablen isLong

bool isLong = IsLong(userChoice);

Console.WriteLine(result);



/* ------------- Methods -------------  */

// Add method med returtype int, der tager 2 tal som parametre og returnere summen
int AddMethod (int a, int b) {
    return a + b;
}

// IsLOng method med returtype bool, der tager en string som parameter og
// tjekke om string er længere en 10 char. Returnere enten true eller false

bool IsLong(string input) {
    if (input.Length > 10) {
        return true;
    }
    return false;
}
  
      
        
    