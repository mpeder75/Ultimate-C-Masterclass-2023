
/* Out keyword bruges ex. Hvis man ønsker at returnere 2 resultater fra em method */


// Eksempel: Array med positive og negative tal,
/* 
 man øsker at returnere positive tal i et array,
 og en integer der returnere hvor mange negative tal der er 
*/

var numbers = new[] { 10, -8, 2, 12, -17 };         // Array med tal man vil tjekke

int nonPositiveCount;                               // Opbevare non positive integers
var onlyPositive = GetOnlyPositiveNumbers(numbers, out nonPositiveCount);
for (int i = 0; i < onlyPositive.Count; i++)
{
    var positiveNumber = onlyPositive[i];
    Console.WriteLine(positiveNumber);
}

Console.WriteLine($"Count of non-positive numbers: {nonPositiveCount}");


// Her bruges out i method decklaration: out int countOfNonPositive
List<int> GetOnlyPositiveNumbers(int[] numbers, out int countOfNonPositive)
{
    countOfNonPositive = 0;
    var result = new List<int>();

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            result.Add(numbers[i]);
        } else
        {
            countOfNonPositive++;
        }
    }

    return result;
}