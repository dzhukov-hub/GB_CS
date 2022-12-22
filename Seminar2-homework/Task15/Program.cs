using static System.Console;
WriteLine ("Введите цифру дня недели (1-7)");
int x = int.Parse(ReadLine());
if (x==6 || x==7)
    WriteLine ("Да");
    else if (x==1 || x==2 || x==3 || x==4 || x==5)
        WriteLine ("Нет");
        else
            WriteLine ("Введенная цифра не является днем недели");
