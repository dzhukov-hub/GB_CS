using static System.Console;
WriteLine ("Введите первое число");
int x1 = int.Parse(ReadLine());
WriteLine ("Введите второе число");
int x2 = int.Parse(ReadLine());
WriteLine ("Введите третье число");
int x3 = int.Parse(ReadLine());
int max=x1;
if (x2>max)
    max=x2;
if (x3>max)
    max=x3;

WriteLine ($"Максимальное число {max}");