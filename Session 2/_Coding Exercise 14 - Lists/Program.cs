/*
Lists - GetOnlyUpperCaseWords
Implement the GetOnlyUpperCaseWords method, which given a collection of strings, 
returns a List with only those strings which contain only uppercase letters.

The result collection should not contain duplicates. 
Digits and special characters are not letters at all, so words containing them should not be considered uppercase words.

For example:

for input List {"one", "TWO", "THREE", "four"} the result shall be {"TWO", "THREE"}

Tips:

Strings are collections of characters. It means we can iterate a string with a foreach loop, 
and in each iteration we have access to a specific character from this string.
*/


// 1. Liste med ord der skal bruges
List<string> myStrings = new List<string> { "one", "TWO", "THREE", "four" };


List<string> upperCaseWords = GetOnlyUpperCaseWords(myStrings);

foreach(string printUpperCase in upperCaseWords)
{
    Console.WriteLine(printUpperCase);
}



// 2. metode der returnere List<string> og som argument modtagerden også en List<string>
List<string> GetOnlyUpperCaseWords (List<string> words)
{
    // tom list oprettes, det er denne som sendes retur
    List<string> myResult = new List<string>();

    // der itereres igennem metodens modtage List (words)
    foreach(string myString in words)
    {
        if(myString.Equals(myString.ToUpper()))     // elementet i words tjekkes for om det er UPPERCASE med .toUpper 
        {                                           // er det string UPPERCASE, indsættes det i List myResult    
            myResult.Add(myString);                 
        }
    }

    return myResult;                                // myResult returneres
}