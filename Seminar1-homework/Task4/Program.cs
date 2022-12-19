using static System.Console;
WriteLine("Ввведите число");
int n = int.Parse(ReadLine());
int i = 1;
while (i<=n)
{
    if (i%2==0)
    {
        if (i!=2)
            Write (", ");    
        Write (i);
    }
    i++;
}