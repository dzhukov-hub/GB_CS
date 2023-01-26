using static System.Console;
Clear();
double[] Arr = new double[4];

DeclareArr();
double MaxMinArrDifference = GetMaxMinDifference(Arr);
PrintArr(Arr);
WriteLine();
WriteLine($"Разница между максимальным и минимальным элементом массива: {Math.Round(MaxMinArrDifference, 1)}");


void DeclareArr()
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().NextDouble() * 100;
        Arr[i] = Math.Round(Arr[i], 1);
    }
}

double GetMaxMinDifference(double[] Arr)
{
    double ArrMin = Arr[0];
    double ArrMax = Arr[0];
    foreach (var a in Arr)
    {
        ArrMin = a < ArrMin ? a : ArrMin;
        ArrMax = a > ArrMax ? a : ArrMax;
    }
    return ArrMax - ArrMin;
}

void PrintArr(double[] Arr)
{
    string res = "";
    Write("[");
    foreach (var i in Arr)
    {
        res += $"{i},";
    }
    Write($"{res}".Trim(','));
    Write("]");
}