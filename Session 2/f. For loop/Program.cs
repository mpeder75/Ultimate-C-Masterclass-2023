

// Eksempel: Her printes til konsol 5 gange
for (int i = 0; i < 5; i++) 
{
    Console.WriteLine("Iteration: " + i);
}


// Eksempel: Her læges 2 til tællevariabel ved hver iteration
for (int a = 0; a < 10; a += 2) {
    Console.WriteLine("Number is" + a);
}


// Eksempel: Loop baglæns fra 10 til 0

for (int j = 10; j >= 0; j--) {
    Console.WriteLine("number is: " + j);
}


// Eksempel: evigt loop -> y starter på 100, condition siger der skal exit hvis y er større end 50 
for (int y = 100; y > 50; y++) {
    Console.WriteLine("number is: " + y);
}


// Eksempel: her beregnes renten at det passed tal med et for loop 
for (double rate = 2.0; rate >= 5.0; rate++) {
    double interestAmount = CalculateInterest(10000, rate);
    Console.WriteLine("10.000 at rate " + rate + " % interest = " + interestAmount);
}



/* for loop: starter rate = 2.0 og skal slutte på rate = 5.0
   interestAmount assigned det metoden CalculateInterest returnere med argument 10000, rate   
 */
 
 // Eksempel: her beregnes renten på 100 kr når rente starter på 7.5 og slutter på 10
 // renten vil stige med 0.25 pr. iteration, 
for (double i = 7.5; i >= 10; i += 0.25) {
    double myInterestAmount = CalculateInterest(100, i);
    Console.WriteLine($"100 at a interest rat of  {i} % interest = {myInterestAmount}");
    
}


// Her breakes ud af loop når interest er $8.5 eller mere
for (double i = 7.5; i < 10; i += 0.25) {

    double myInterest = CalculateInterest(100, i);
    if (myInterest > 8.5) {
        break;
    }
    Console.WriteLine($"100 at a interest rat of  {i} % interest = {myInterest}");
}

double CalculateInterest(double amount, double interestRate) {

    return (amount * (interestRate / 100));
}