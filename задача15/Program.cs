// напишите программу, которая принимает на вход цифру, обозначающую день недели , и проверяет, является ли этот день выходным
Console.Clear();
Console.WriteLine("Введите номер дня недели - число от 1 до 7");
int x = int.Parse(Console.ReadLine());
if (x <= 5) 
{
Console.WriteLine("Это будний день");
}
else if (x <= 7)
{
Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Введите число соответствующее дню недели");
}





