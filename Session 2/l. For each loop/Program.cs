/*
 For-each loop er designet til at loope igennem arrays, Lister og collections
*/


var words = new[] {"one", "two", "three", "four" };
string[] cars = { "BMW", "Corvette", "Mustang" };


// ---------------------------- For Loop ----------------------------- //

for (var i = 0; i < words.Length; i++)
{
    Console.WriteLine($"Printing from for loop {words[i]}");
}


// ---------------------------- For Each Loop ----------------------------- //

// 'String' er elementernes datatype 
// 'car' er navnet på det element man arbejder på
// 'in' er keyword for man vi larbejde på noget
// 'cars' er det array men vil iterere igennem

foreach(string car in cars)
{
    Console.WriteLine(car);
}

/* 

 * For each loops kan KUN itere forlæns IKKE BAGLÆNS -> Brug et forloop eller while loop istedet for 
 * For-each loop kan IKKE springe en iteration over -> For loop kan i sin declaration (int i = 0; i > 10; i += 2);

*/



