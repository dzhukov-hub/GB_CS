using static System.Console;
Clear();
Write("Введите число M:");
int m = int.Parse(ReadLine());
WriteLine();
Write("Введите число N:");
int n = int.Parse(ReadLine());
int ret = 0;
WriteLine();
GetSumNaturalNumbers(m, n, ret);
WriteLine();

void GetSumNaturalNumbers(int m, int n, int ret)
{
    if (m == n) WriteLine($"Сумма натуральных элементов в промежутке от M до N: {(ret + m)}");
    else
    {
        ret += m;
        m++;
        GetSumNaturalNumbers(m, n, ret);
    }
}
