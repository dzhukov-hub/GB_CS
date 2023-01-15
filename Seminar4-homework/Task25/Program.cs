using static System.Console;
Clear();
WriteLine ("Введите число A:");
int a = int.Parse(ReadLine());
WriteLine ("Введите число B:");
int b = int.Parse(ReadLine());

WriteLine ($"Число A в натуральной степени числа B = {PowerOf(a,b)}");

int PowerOf (int a, int b)
{
    int i = 1;
    int res=1;
    while (i<=b)
        {
            res = res*a;
            i++;
        }
    return res;
}

