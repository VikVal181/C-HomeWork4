// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write($"{NumSum(A)}");

int NumSum(int num)
{
    int result = 0;

    while (num > 0)
    {
        result += num %10;
        num = num / 10; 
    }

    return result;
}