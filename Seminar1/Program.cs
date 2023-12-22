// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());


// if (firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine("Да, " + firstNumber + " является квадратом от " + secondNumber);
// }
// else
// {
//     Console.WriteLine("НЕТ, " + firstNumber + " НЕ является квадратом от " + secondNumber);
// }

// Напишите программу, которая на вход 
// принимает целое число N, а на выходе 
// показывает все целые числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4 
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 0)
{
    N = N * -1;
}

int negativeN = -N;

while (negativeN <= N)
{
    Console.Write(negativeN + "\t");
    negativeN++;
}