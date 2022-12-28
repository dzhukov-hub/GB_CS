using static System.Console;
WriteLine("Введите число N:");
int.TryParse(ReadLine(), out int n);
int inc=1;
while (inc<=n)
{
    WriteLine($"Квадрат числа {inc} - {Math.Pow(inc, 3)}");
    inc++;
}

