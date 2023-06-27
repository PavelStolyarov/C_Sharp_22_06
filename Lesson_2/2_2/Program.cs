int Max(int count)
{
    int ones = count % 10;
    int tens = count / 10;
    Console.WriteLine(tens);
    if(ones > tens)
    {
        return ones;
    }
    else
    {
        return tens;
    }
}
int num = new Random().Next(10, 99);
Console.WriteLine($"Generated number: {num} " );
int result = Max(num);
Console.WriteLine(result);