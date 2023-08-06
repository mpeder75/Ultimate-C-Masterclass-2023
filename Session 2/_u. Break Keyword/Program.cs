/*
 
Break gør at der breakes ud af et loop øjeblikkeligt

*/


/* ------  Eksempel: Her breakes der ud af loop når i == 10 ------ */
for (int i = 0; i < 100; i++) {

    if (i == 10) {
        break;
    }
    Console.WriteLine("Iteration " + i + " of 100");
}


/*
Eksempel: bruger skal indtaste et nummer større end 10,
hvis bruger indtaster et nummer mindre end 10 skal loop fortsætte med at spørge,
og stopper først når nummer er større end 10 
*/

// variabel der opbevare userNumber fra do delen
int userNumber; 

do {
    Console.WriteLine("Enter number larger than 10: ");     // spørger om bruger input af tal større end 10
    var userInput = Console.ReadLine();                     // input aflæses og gemmes i userInput
    userNumber = int.Parse(userInput);                      // userNumber assigned den parsede værdi af userInput
} while(userNumber <= 10);


/*
Eksempel: bruger skal indtaste et nummer større end 10,
hvis bruger indtaster et nummer mindre end 10 skal loop fortsætte med at spørge og stopper når nummer er større end 10.
Bruger kan afslutte loop ved at skrive "stop"
*/

// variabel der opbevare userNumber fra do delen
int userNumber1; 

do {
    Console.WriteLine("Enter number larger than 10 ('stop' for exit): ");    
    var userInput1 = Console.ReadLine();                    // input aflæses og gemmes i userInput

    if (userInput1 == "stop" || userInput1 == "Stop") {     // HVIS bruger indtaster "stop" vil der breakes ud af loop
        break;
    }
    
    userNumber1 = int.Parse(userInput1);                    // userNumber assigned den parsede værdi af userInput
} while(userNumber1 <= 10);
