
// Declare int array med størrelsen 3
int[] num1 = new int[3];


// Assign elementer i array med værdier
num1[0] = 15;
num1[1] = 16;
num1[2] = 17;

// Declare & initialize med Array initializer
int[] num2 = new []{ 2, 5, 7, 3, 1, 10 };

// eller
var num3 = new[] { 3, 6, 5, 2, 8, 7 };


// Printe elementer fra array ud
Console.WriteLine("Element at index 0 is : " + num1[0]);
Console.WriteLine("Element at index 1 is : " + num1[1]);
Console.WriteLine("Element at index 3 is : " + num1[2]);

//  Modificere et element efter det er assigned
num1[0] = 5;
num1[1] = 6;
num1[2] = 7;

// Tilgå array sidste index og andet sidste index
int[] myArray = new int[5];

myArray[0] = 5;
myArray[1] = 6;
myArray[2] = 7;
myArray[3] = 8;
myArray[4] = 9;

var firstFromEnd = myArray[myArray.Length - 1];
var secondFromEnd = myArray[myArray.Length - 2];

Console.WriteLine("First from end: " + firstFromEnd);
Console.WriteLine("Second from end: " + secondFromEnd);


// Iterere gennem array med for loop, og lægge alle elementer sammen
int[] numbers = new[] { 6, 4, 7, 3, 9 };

var sum = 0;

for (var i = 0; i < numbers.Length; i++) {
    sum += numbers[i];
}

Console.WriteLine("The total sum of array elements is:" + sum);
