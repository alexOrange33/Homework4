// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
string exit = String.Empty;
while(exit!="yes")
{
Console.Clear();
Console.WriteLine("Введите число:");
int value = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{value} -> {Summa(value)}");
Console.Write("Чтобы выйти наберите yes: ");
exit = Console.ReadLine()!;
}
//----metod----------
int Summa(int value)
{
    int summa = 0;
    if(value<0) value = value*(-1);
    while(value>0)
    {
        summa = summa + value%10;
        value = value/10;
    }
    return summa;
}