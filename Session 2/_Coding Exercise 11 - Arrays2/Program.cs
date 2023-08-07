/*
Implement the IsWordPresentInCollection method, which given an array of words and a wordToBeChecked, 
returns true if wordToBeChecked is present in this collection and false otherwise.

For example:
For words equal to {"one", "two", "three"} and wordToBeChecked equal to "hello" 
the result shall be false because the word "hello" is not present in the words array.
 */

bool IsWordPresentInCollection(string[] words, string wordToBeChecked) {

    for (int i = 0; i < words.Length; i++) {

        if (words[i] == wordToBeChecked) {
            return true;
        }
    }
    return false;
}
    

// 1. iterer gennem array
// 2. check at det index for loop er i, matcher wordsToBeChecked
// 2a. HVIS det gør return true
// 2b. HVIS IKKE return false 

