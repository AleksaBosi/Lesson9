﻿//  63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void f(int max)
// {
//     if (max != 0)
//     {
//         f(max - 1);
//         Console.Write(max + " ");
//     }
// }
// int max = 10;
// f(max);



// 65
// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// void f(int max, int min)
// {
//     if (max != (min - 1))
//     {
//         f(max - 1, min);
//         Console.Write(max + " ");
//     }
// }

// int max = 10;
// int min = 3;
// f(max, min);

// 67
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int f(int max)
// {
//     if (max == 0)
//         return 0;
//     return f(max / 10) + max % 10;
// }
// int max = 546;
// Console.Write(f(max));


// 69
// Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В с помощью рекурсии.
// А = 3; b = 5 -> 243 (3 в 5)
// А = 2; b = 3 -> 8

// int f(int a, int b)
// {
//     if (b == 0)
//         return 1;
//     return f(a, b - 1) * a;
// }
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine()); ;
// Console.Write(f(a, b));







