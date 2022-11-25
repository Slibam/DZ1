//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели");
int DenNedeli = Convert.ToInt32(Console.ReadLine());
if (DenNedeli == 1)
{
    Console.WriteLine("Пн");
     Console.WriteLine("Этот день не выходной");
}
else if (DenNedeli == 2)
{
    Console.WriteLine("вт");
     Console.WriteLine("Этот день не выходной");
}
else if (DenNedeli == 3)
{
    Console.WriteLine("ср");
     Console.WriteLine("Этот день не выходной");
}
else if (DenNedeli == 4)
{
    Console.WriteLine("чт");
     Console.WriteLine("Этот день не выходной");
}
else if (DenNedeli == 5)
{
    Console.WriteLine("Пт");
     Console.WriteLine("Этот день не выходной");
}
else if (DenNedeli == 6)
{
    Console.WriteLine("суб");
    Console.WriteLine("Этот день выходной");
}
else if (DenNedeli == 7)
{
    Console.WriteLine("вос");
     Console.WriteLine("Этот день выходной");
}
