/*
Methods - AbsoluteOfSum method
Define the AbsoluteOfSum method, which takes two int parameters, and returns the absolute value of their sum.

Absolute value is the non-negative value of the number, without regard to its sign. 
So for example, the absolute value of 5 is 5, and the absolute value of -10 is 10.
*/

Console.WriteLine("Please enter number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

var result = AbsoluteValue(num1, num2);
Console.WriteLine(result);


int AbsoluteValue(int a, int b) {
    Console.WriteLine("you entered " + num1 + " and " + num2);
    Console.WriteLine("Lets add these together:" );
    return Math.Abs(a + b);
}