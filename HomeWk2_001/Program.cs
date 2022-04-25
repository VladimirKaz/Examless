int GetNumber()
{
    int value = new Random().Next(10, 100);
    int a = value / 10; // Показывает первое число
    int b = value % 10; // Показывает второе число
    //System.Console.WriteLine($"value: {value} a: {a} b: {b}");
    //проверяем как работает функция
    int max = a;
    if (b > max) max = b;
    return max;
}
System.Console.WriteLine(GetNumber());




