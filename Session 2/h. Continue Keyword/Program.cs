/*
 
Continue gør at der fortsættets til næster iteration - "Det man er i gang med springer man over"
 
*/


/*
Eksempel: Her printes alle tal fra 0 til 20, UNDTAGE de tal der kan divideres med 3
 */

for (var i = 0; i < 20; i++) {

    if (i % 3 == 0) {   // tal der kan divideres m. 3 springes over, printes ikke (hopper altså op i loop igen)
        continue;
    }
    Console.WriteLine("i is " + i);
}


/*
Eksempel: bruger skal indtaste et nummer større end 10,
hvis bruger indtaster et nummer mindre end 10 skal loop fortsætte med at spørge og stopper når nummer er større end 10.
Bruger kan afslutte loop ved at skrive "stop"
*/

// variabel der opbevare userNumber fra do delen
int userNumber; 

do {
    Console.WriteLine("Enter number larger than 10 ('stop' for exit): ");    
    var userInput = Console.ReadLine();                     // input aflæses og gemmes i userInput

    if (userInput == "stop" || userInput == "Stop") {       // HVIS bruger taster "stop" vil der breakes ud af loop
        break;
    }

    bool isParsableToInt = userInput.All(char.IsDigit);     // Her tjekkes om userInput er et tal
    
    if (!isParsableToInt) {                                 // HVIS userInput IKKE er en int, hopped der retur til 
        userNumber = 0;                                     // do delen, og spørger igen om bruger input
        continue;                                         
        
    }
    userNumber = int.Parse(userInput);                      // userNumber assigned den parsede værdi af userInput
} while(userNumber <= 10);
