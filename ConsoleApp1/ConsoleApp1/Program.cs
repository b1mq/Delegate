
using System;
Action ShowTimeAction = () => Console.WriteLine($"Time: {DateTime.Now.ToString("HH:mm:ss")}");
Action ShowDayOfTheWeekAction = () => Console.WriteLine($"Day: {DateTime.Now.DayOfWeek}" );
Action ShowDataAction = () => Console.WriteLine($"Data: {DateOnly.FromDateTime(DateTime.Now).ToString()}" );

Func<double, double, double> S_Triangle = (a, b) => 0.5 * a * b;
Func<double,double,double>  S_Rectangle= (a,b) => a*b;
//double res = S_Triangle(1,2);
#region 1

SearchDelegateType X = GetEven;
SearchDelegateType Y = GetOdd;
DelegateISType Z = IsPrime;
int[] GetEven(int[] arr)
{
    List<int> res = new List<int>();
    foreach (int i in arr)
    {
        if (i % 2 == 0)
        {
            res.Add(i);
        }
    }
    return res.ToArray();
}

int[] GetOdd(int[] arr)
{
    List<int> res = new List<int>();
    foreach (int i in arr)
    {
        if (i % 2 != 0)
        {
            res.Add(i);
        }
    }
    return res.ToArray();
}

bool IsPerfectSquare(long x)
{
    long s = (long)Math.Sqrt(x);
    return s * s == x;
}

int[] GetFibonacci(int[] arr)
{
    List<int> res = new List<int>();
    foreach (int n in arr)
    {
        if (n < 0) break;
        long x1 = 5L * n * n + 4;
        long x2 = 5L * n * n - 4;
        if (IsPerfectSquare(x1) || IsPerfectSquare(x2))
        {
            res.Add(n);
        }
    }
    return arr.ToArray();
}

bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i * i <= n; i++)
        if (n % i == 0) return false;
    return true;
}
Func<int[], int[]> fibonacci = GetFibonacci;
Predicate<int> isPrimePredicat = IsPrime;

public delegate bool DelegateISType(int n);
public delegate int[] SearchDelegateType(int[] arr);
#endregion

