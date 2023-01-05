/*Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число:");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (a<100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (a>999)
    {
        a = a/10;
    }
    Console.WriteLine(a%10);
}