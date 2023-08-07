/*
Using the for loop, implement the Factorial method, which calculates the factorial of a given number.
Factorial of number N is the result of multiplying all integers from 1 to N.

N! = 1 * 2 * 3 * ... * (N-1) * N

For example:

5! = 1*2*3*4*5 = 120
4! = 1*2*3*4 = 24

Assume the number parameter is non-negative.
*/

// Her kaldes Factorial method med argumentet 4
Console.WriteLine(Factorial(4));



int Factorial(int number)
{
    // result variabel, der bruges til at opbevare det resultat der skal returneres
    int result = 1;
            
    // loopes fra 1 til det number der er passed til Factorial method (4) 
    for(int i = 1; i <= number ; i++) {
        
       result *= i;
    }

    return result;
}
              
// Husk Factorial er 4*3*2*1 = 24