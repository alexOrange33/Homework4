// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

string exit = String.Empty;
while(exit != "yes")
{
Console.Clear();
int[] array = new int[8];
array = GetArray(array);
Console.WriteLine($"Массив: [{String.Join("\t", array)}]");
Console.Write("Чтобы выйти наберите yes: ");
exit = Console.ReadLine()!;
}
//------metod-------
int[] GetArray(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}