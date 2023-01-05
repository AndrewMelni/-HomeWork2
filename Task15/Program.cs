/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным. */

Console.WriteLine("Введите число:");
int day = Convert.ToInt32(Console.ReadLine());
if (day<1 || day>7)
{
    Console.WriteLine("Некорректное число, введите число от 1 до 7");
}
else
{
    if (day<=5)
    {
        Console.WriteLine("Не выходной");
    }
    else
    {
        Console.WriteLine("Выходной");
    }
}

/* string mes;
Console.WriteLine("Введите день недели: от 1 до 7");
string day = Console.ReadLine();
switch (day)
{ 
case "6": mes = "Да, выходной"; break;
case "7": mes = "Да, выходной"; break;
default: mes = "Не выходной"; break;
}
Console.WriteLine(mes); */