/*
Implement the DescribeDay method, which given a day of the week as a number, should return:
 - "Working day" for numbers 1 to 5
 - "Weekend" for numbers 6 and 7
 - "Invalid day number" for any other number
*/

string dayNumber = "";

switch (dayNumber) {
                
 case "5":
 case "4":
 case "3":
 case "2":
 case "1":
  Console.WriteLine("Working day");
  break;
 case "7":
 case "6": 
  Console.WriteLine("Weekend");
  break;         
 default: 
  Console.WriteLine("Invalid day number");
  break;
}
