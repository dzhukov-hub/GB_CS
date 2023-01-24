using static System.Console;
Clear();
Write("Введите значение переменной b1: ");
double b1 = int.Parse(ReadLine());
WriteLine();
Write("Введите значение переменной k1: ");
double k1 = int.Parse(ReadLine());
WriteLine();
Write("Введите значение переменной b2: ");
double b2 = int.Parse(ReadLine());
WriteLine();
Write("Введите значение переменной k2: ");
double k2 = int.Parse(ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
WriteLine();
WriteLine($"Координаты точки пересечения прямых: x={x}, y={y}");

