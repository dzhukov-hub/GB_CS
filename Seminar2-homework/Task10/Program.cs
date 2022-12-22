using static System.Console;
WriteLine ("Введите трехзначное число");
int x = int.Parse(ReadLine());

if (x<1000 && x>99)
    WriteLine ($"Вторая цифра введенного числа: {(x/10)%10}");
else 
    WriteLine ("Введенное число не является трехзначным");


