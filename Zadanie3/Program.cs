//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите 3х значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num > 999)
{
    num = num / 10;
}
    if (num < 100 )
    {
        Console.WriteLine("Третья цифра отсутствует");
    }
    else 
    {
        int tens = num / 10;
        int ones = num % 10;
        Console.WriteLine("Третья цифра " + ones);
    } 