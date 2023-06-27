// 3. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Enter number: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = num1 * -1;
if(num1 >= 0)
{
    while(num2 <= num1)
    {
        Console.Write(num2);
        Console.Write(" ");
        num2++;
    }
}
else
{
    while(num2 >= num1)
    {
        Console.Write(num2);
        Console.Write(" ");
        num2--;
    }
}
