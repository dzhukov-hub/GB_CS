using static System.Console;
WriteLine ("Введите число");
int x = int.Parse(ReadLine());
if (x>99)
    WriteLine ($"Третья цифра введенного числа: {((x/10)/10)%10}");
else 
    WriteLine ("Третьей цифры нет");