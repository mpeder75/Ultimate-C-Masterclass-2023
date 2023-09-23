/*
 
Foreach loop - IsAnyWordLongerThan
Using the foreach loop, implement the IsAnyWordLongerThan method, which given a length and an array of words, 
returns true if any of those words is longer than the given length, and false otherwise.

For example:

for length 4 and words {"aaa", "bbbb", "ccccc"} the result returns true, because "ccccc" is longer than 4 letters

for length 5 and words {"aaa", "bbbb", "ccccc"} the result returns false because no word is longer than 5 letters

for length 5 and an empty array, the result shall be false because no word is longer than 5 letters

*/

string[] words = new string[] {"a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa"};


bool myBool = IsAnyWordLongerThan(6, words);
Console.WriteLine(myBool);

bool IsAnyWordLongerThan (int length, string[] words)
{

	foreach (var word in words)
	{
		if(word.Length > length)
		{
			return true;
		}
	}
	return false;


}