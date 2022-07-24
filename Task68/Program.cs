// 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа min и max.
// min = 2, max = 3 -> A(min,max) = 29


int AckermanFunctions(int min, int max)
{
    if (min == 0)
        return max + 1;

    else if (max == 0)
        return AckermanFunctions(min - 1, 1);

    else return AckermanFunctions(min - 1, AckermanFunctions(min, max - 1));
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(AckermanFunctions(m, n));