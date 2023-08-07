

var words = new[] {"one", "two", "three", "four" };
var numbers = new[] {"one", "two", "three", "four" };

// For loop looper gennem array
for (var i = 0; i < words.Length; i++) 
{
    Console.WriteLine(words[i]);
}


/* For Each loope har IKKE adgang til [i] */

// Foreach looper gennem array
foreach (var number in numbers) 
{
    Console.WriteLine("For each printing " + number);
}

Console.ReadKey();

