// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// Console.WriteLine("Введите число:");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число:");
// int B = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{A} в степени {B} -> {Pow(A,B)}");

// int Pow(int num, int num2)
// {
//     if(B==0) return 1;
//     int result = num;
//     for(int i = 2; i <= num2; i++)
//     {
//         result *= num;
//     }
//     return result;
// }





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{number} -> {GetSum(number)}");

int GetSum(int num)
{
    int sum = 0;
    while (num>0)
    {
        sum+=num%10;
        num/=10;
    }
    return sum;
}
