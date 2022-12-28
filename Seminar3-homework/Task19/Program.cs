using static System.Console;
WriteLine ("Введите пятизначное число:");
int x = int.Parse(ReadLine());
if (x<10000 || x>99999)
    WriteLine ("введенное число не является пятизначным");
else
    if ((x/10000 == x%10) & (x/1000%10==x%100/10))
        WriteLine ("да");
    else
        WriteLine ("нет");