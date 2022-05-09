int num0( int N )
{
    if (N > -10000 && N < 100) return  ( N / 10 ) % 10;
    return -1;
}

int Num1 = -4356;

System.Console.WriteLine(-num0(Num1));

