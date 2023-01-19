using static System.Console;
WriteLine("Введите число:");
int num = int.Parse(ReadLine());
int cnt = 1;

WriteLine(GetNumberLength(num));


int GetNumberLength(int num)
{
    while (num / 10 != 0)
    {
        num = num / 10;
        cnt++;

    }
    return cnt;
}
