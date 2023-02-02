using static System.Console;
Clear();
Write("Введите число N:");
int n = int.Parse(ReadLine());

PrintRecursiveNto1(n);

void PrintRecursiveNto1(int n)
{
    if (n == 1) Write($"{n}");
    else
    {
        Write($"{n},");
        n--;
        PrintRecursiveNto1(n);

    }
}
