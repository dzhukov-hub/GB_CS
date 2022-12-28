using static System.Console;
WriteLine ("Введите координату X точки A:");
if (!int.TryParse (ReadLine(), out int xa ))
{
    WriteLine ("Введена не цифра!");
    return;
}
WriteLine ("Введите координату Y точки A:");
if (!int.TryParse (ReadLine(), out int ya ))
{
    WriteLine ("Введена не цифра!");
    return;
}
WriteLine ("Введите координату Z точки A:");
if (!int.TryParse (ReadLine(), out int za ))
{
    WriteLine ("Введена не цифра!");
    return;
}

WriteLine ("Введите координату X точки B:");
if (!int.TryParse (ReadLine(), out int xb ))
{
    WriteLine ("Введена не цифра!");
    return;
}
WriteLine ("Введите координату Y точки B:");
if (!int.TryParse (ReadLine(), out int yb ))
{
    WriteLine ("Введена не цифра!");
    return;
}
WriteLine ("Введите координату Z точки B:");
if (!int.TryParse (ReadLine(), out int zb ))
{
    WriteLine ("Введена не цифра!");
    return;
}
double ab_length = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
WriteLine ($"{ab_length:f2}");


