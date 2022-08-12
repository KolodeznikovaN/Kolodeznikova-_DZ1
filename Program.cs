// Напишите программу, которая принимает на входе трехзначное число и на выход показывает вторую цифру этого числа 
// 456 -> 5 
// 782-> 8 
// 918-> 1

Console.Write ("Введите трехзначное число: ");

int threetDigitNumber = Convert.ToInt32 (Console.ReadLine());
string stringNumber = Convert.ToString (threetDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);


// Напишите программу , которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 
// 78-> 8третьей цифры нет 
// 32679-> 6

Console.Write ("Введите число: ");
int anyNumber = Convert.ToInt32 (Console.ReadLine());
string anyNumberText = Convert.ToString (anyNumber);
if (anyNumberText.Length > 2) {
    Console.WriteLine ("третья цифра -> " + anyNumberText [2]);
}
 else {
    Console.WriteLine ("третьей цифры нет");  
 }
			
