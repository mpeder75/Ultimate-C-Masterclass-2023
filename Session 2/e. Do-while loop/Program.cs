
/* ---- do-while loop ---- */

// Eksempel: bruger skal indtaste et ord som skal være 10 letters eller længere
// HVOR der fortsættets med at spørge indtil der er indtastet ord, med korrekt længde   

string word1;

do {
    Console.WriteLine("Enter word longer than 10 letters : ");
    word1 = Console.ReadLine();
} 
while (word1.Length <= 10);



/* ----- while loop ----- */

// Bruger skal indtaste ord der er kortere end 3 bogstaver

var word3 = "213445";

while (word3.Length >= 3) {
    Console.WriteLine("Enter word longer than 10 letters : ");
    word3 = Console.ReadLine();
}





Console.WriteLine("Loop is finished");
Console.ReadKey();











 