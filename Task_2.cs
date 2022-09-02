int Max(int a, int b, int c)
{
    int result = a;
    if(b > result) result = b;
    if(c > result) result = c;
    return result;
}

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());


int max = Max(a,b,c);
     

Console.WriteLine($"Максимальное число: {max}");