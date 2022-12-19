using static System.Console;
WriteLine("Введите первое число");


int x1 = int.Parse(ReadLine());  
WriteLine ("Введите второе число");
int x2 = int.Parse(ReadLine());

if (x1>x2) 
    WriteLine("Первое число больше второго");
    else if (x2>x1) 
        WriteLine("Второе число больше первого");
        else
            WriteLine("Числа равные");
