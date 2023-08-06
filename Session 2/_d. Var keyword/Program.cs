
/* -------- VAR keyword --------- */

/* 
 *  C# compiler er kan håndtere både explicitly typed variabels og implicitly typed variabels
 *  Uanset om man bruger explicitly eller implicitly SKAL de declares, og initializes på SAMME måde
 *  BRUG implicit (var) oftest - og når der er variabler der skal være tydelige brug explicitly
*/


// explicitly typed variabels er når man declare med en datatype
string word1 = "ABC";
int number1 = 5;


// implicitly typed variabels - C# compiler kan altså selv tolke at datatypen skal være string og int
var word2 = "ABC";
var number2 = 5;





