/*Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a<100 || a>999)
{
    Console.WriteLine("Некорректно введено число!");
}
else
{
    int b = a/10;
    Console.WriteLine(b%10);
}