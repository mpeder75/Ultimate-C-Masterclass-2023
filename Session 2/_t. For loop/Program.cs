

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