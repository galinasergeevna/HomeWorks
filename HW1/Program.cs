﻿
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 
if(num1 > num2)
{
    Console.WriteLine($"The {num1} is greater than the {num2} ");
}
else if (num1 < num2)
{
    Console.WriteLine($"The {num1} is less than the {num2} ");
}
else
{
    Console.WriteLine($"{num1} and {num2} are equal");
}
