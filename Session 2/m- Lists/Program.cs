

// Her declares en tom List
List<string> myWords = new List<string>();

// Her declares en List med elementer
List<string> myWords1 = new List<string> { "One", "two", "three", "four", "five" };

// Her declares en List implicitly
var myWords2 = new List<string> { "One", "two", "three", "four", "five" };


/* ------------------------------------------------------------------------------------------- */


// Her tjekes hvad længden på List
Console.WriteLine($"The Count of the list is: {myWords1.Count}");


// Tilføje element til List
myWords.Add("Hello");
myWords.Add("there");
Console.WriteLine($"The Count of the list is: {myWords.Count}");


// Ændre element
myWords[0] = "Uno";
myWords[1] = "Dos";


// Fjerne et element fra en liste med et søge ord - RemoveAt method
myWords2.Remove("One");                                     // her indsættes et "ord" man gerne vil fjerne,
                                                            // og når Remove finder den første "one" fjernes den
                                                            // Den fjerner ikke duplikanter


// Fjerne et element fra en Liste med index - RemoveAt method
myWords2.RemoveAt(1);

// Fjerne alle elementer i en List - Clear method
List<string> myWords3 = new List<string> { "1", "2", "3"};
Console.WriteLine($"MyWords3 Count is: {myWords3.Count}");

myWords3.Clear();
Console.WriteLine($"MyWords3 Count after Clear: {myWords3.Count}");


// Indsætte flere elementer på en gang - AddRange method
var words = new List<string> { "One", "Two", "Three" };     // Liste der skal tilføjes til

var moreWords = new[] { "Four", "Five", "Six" };            // Array opretts med de ord men gerne vil tilføje
words.AddRange(moreWords);                                  // AttRange metoden bruges og argumentet er array med ord


// Få et givent elements index position - IndexOf method
Console.WriteLine($"Index of element 'four' is {myWords2.IndexOf("four")}");

// Find ud af om et element findes - Contains method - Returnere en boolean
Console.WriteLine($"Contains 'Five' {words.Contains("Five")}");
Console.WriteLine($"Contains 'Six' {words.Contains("Six")}");







/* ------------------------------------------------------------------------------------------- */


// Her printes alle elementer med for-each loop
foreach (var myWord in myWords1)
{
    Console.WriteLine(myWord);
}

// Her printes alle elementer med for loop
for (int i = 0; i < myWords1.Count; i++)
{
    Console.WriteLine(myWords1[i]);
}

