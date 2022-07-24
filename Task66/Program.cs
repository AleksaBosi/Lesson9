// 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Integers(int max, int min, int sum = 0)
{
    if (min <= max)
    {
        sum = sum + min;
        if (sum != 0)
        {
            min = min + 1;
        }
        return Integers(max, min, sum);
    }
    return sum;
}

int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
Console.Write(Integers(max, min));
