﻿Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Да, " + firstNumber + " является квадратом от " + secondNumber);
}
else
{
    Console.WriteLine("НЕТ, " + firstNumber + " НЕ является квадратом от " + secondNumber);
}

