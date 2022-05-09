int num2(int N)
{   
    if ( N > 99 && N < 1000 ) return (N/10)% 10;
    return -1;
}    
int num = 765;
if (num2(num)== -1) Console.WriteLine("Число не трехзначное");
else System.Console.WriteLine(num2(num));
    



