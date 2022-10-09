 // напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа 
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine()!);
int result = 0;
int x1 = x / 10;
if (x1 >= 10 && x1 < 100)
{

result = x % 100 / 10;
Console.WriteLine("Вторая цифра числа {x} -> {result} ");
}
else
{
 Console.WriteLine("Вы ввели не трехзначное число");
}