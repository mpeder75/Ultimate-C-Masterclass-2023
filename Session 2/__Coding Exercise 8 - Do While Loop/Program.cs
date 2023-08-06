

// Her kaldes metoden RepeatCharachter
Console.WriteLine(RepeatCharacter('a', 5));

string RepeatCharacter(char character, int targetLength) {
    
    string result = "";
            
    do {
        result += character;
    } while (result.Length < targetLength);
            
    return result;
}

