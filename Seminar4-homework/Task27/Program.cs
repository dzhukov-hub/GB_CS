using static System.Console;
Clear();
WriteLine("Введите число:");
int num = int.Parse(ReadLine());

WriteLine($"Сумма числ в введенном числе: {GetSumDigits(num)}");

int GetSumDigits(int num)
{
    int res = 0;
    while (num / 10 != 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res + num;
}

