
SearchDelegateType X = GetEven;
SearchDelegateType Y = GetOdd;
DelegateISType Z = IsPrime;

int[] GetEven(int[] arr)
{
    List<int> res= new List<int>();
    foreach(int i in arr)
    {
        if (i % 2 ==  0)
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

bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i * i <= n; i++)
        if (n % i == 0) return false;
    return true;
}


public delegate bool DelegateISType(int n);
public delegate  int[] SearchDelegateType(int[] arr);