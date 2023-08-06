Console.WriteLine("Enter number 1:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number 2:");
int num2 = int.Parse(Console.ReadLine());


Console.WriteLine(CalculateSumOfNumbersBetween(num1, num2));


int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber) {

   // Tællevariabel, sættes til firstNumber, da vi jo skal starte et sted
   int currentNumber = firstNumber; 
   // sum variabel der opbevare summen der returneres fra while loop
   int sum = 0;

   // while loop skal køre så længe currentNumber er mindre end lastNumber
   while (currentNumber <= lastNumber) {
      
      sum += currentNumber;      // Her tilføjer man surrentNumber til sum variablen
      currentNumber++;           //Her increment currentNumber 
   }
   return sum;
}