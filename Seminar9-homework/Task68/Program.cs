using static System.Console;
Clear();
Write("Введите число m:");
int m = int.Parse(ReadLine());
WriteLine();
Write("Введите число n:");
int n = int.Parse(ReadLine());
WriteLine();
WriteLine($"Результат функции Аккермана: {MyFuncCalc(m, n)}");
WriteLine();
int MyFuncCalc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if (n == 0)
        return MyFuncCalc(m - 1, 1);
    else
        return MyFuncCalc(m - 1, MyFuncCalc(m, n - 1));
}