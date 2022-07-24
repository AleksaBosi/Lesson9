// 64
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void Integers(int max, int min)
{
    if (max != (min - 1))
    {
        Integers(max - 1, min);
        Console.Write(max + " ");
    }
}

int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
Integers(max, min);
