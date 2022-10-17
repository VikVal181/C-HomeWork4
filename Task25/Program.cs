// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
if (B <= 0) Console.Write("Второе число должно быть натуральным");
else Console.Write($"{MyPow(A,B)}");

int MyPow(int num1, int num2)
{
    int result = 1;
    for(int i = 0; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}