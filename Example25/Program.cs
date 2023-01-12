// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
string exit = String.Empty;
while(exit != "yes")
{
Console.Clear();
Console.Write("Введите число возводимое в степень:");
double value1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите натуральную степень:");
int value2 = int.Parse(Console.ReadLine()!);
if(value2<0) 
{
    Console.WriteLine("Введена не верная степень");
    Console.ReadLine();
    continue;
}
double result = GetPow(value1,value2);
Console.WriteLine($"{value1} ; {value2} -> {Math.Round(result,value2)}");
Console.Write("Чтобы выйти наберите yes: ");
exit = Console.ReadLine()!;
}
//------metod----------
double GetPow(double A,int B)
{
    if(A == 0 && B == 0) return 1;
    double result = 1;
    for(int i=1;i<=B;i++)
    {
        result = result*A;
    }
    return result;
}
