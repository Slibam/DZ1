//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите 3х значное число: ");
int number     = Convert.ToInt32(Console.ReadLine());
int digitIndex = 1;
int digit = number.ToString()[digitIndex] - '0';
Console.WriteLine ("Вторая цифра " + digit);
