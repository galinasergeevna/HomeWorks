/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Input three-digital number: ");
int number = Convert.ToInt32(Console.ReadLine());

int CutNumber(int number)
{
    int dec = number/10;

    return dec%10;
}
int newNumber = CutNumber(number);
Console.WriteLine($"Two gigital of {number} is {newNumber}");
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdDigitNumber(int number)
{ 
  int ed = number % 10;
  if (number > 99)
    Console.WriteLine($"Third digit is: {ed}");
  else
    Console.WriteLine("Third digit missing");
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdDigitNumber(number);
*/

/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool DayHolliday(int number)
{
    if(number == 6 || number == 7)
       return true;
    else
       return false;
}
Console.Write("Enter the day of the week: ");
int n = Convert.ToInt32(Console.ReadLine ());

bool dayHolliday=DayHolliday(n);
Console.WriteLine(dayHolliday);
*/