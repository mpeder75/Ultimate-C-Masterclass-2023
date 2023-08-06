/*
  number = number + 1;  --- Gør det samme som ---  number +1;
 
  For at increment mere end en:  number += 2;
 
 
  
 */




// HUSK variablen SKAL declares og initializers UDENFOR while loop 
var number = 0;

while (number < 10) {
    number = number + 1;
    // Eller number += 1;
    Console.WriteLine("Number is: " + number);
}

// Lægge en char til en string
var word = "ABC";
word += "D";


// Eksempel: tællevariabel ganges med 2 - husk tællevariabel skal increments til sidst  
var num1 = 0;

while (num1 < 10) {
    num1 *= 2;
    Console.WriteLine("Num1 is " + num1);
    num1++;

}





Console.ReadLine();