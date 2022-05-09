int num (int N)
{
    if (N > 99 && N < 100000) return N % 10;
    return -1;
}
int n = 62679;
if (num(n)==-1) Console.WriteLine("Третьей цифры нет");
else System.Console.WriteLine(num(n));