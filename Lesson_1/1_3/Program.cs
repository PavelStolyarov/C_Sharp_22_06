// 2. Напишите программу, которая будет выдавать название дня
//    недели по заданному номеру.
//Console.Write("Enter num: ");
//int num = int.Parse(Console.ReadLine()!);
//if (num == 1) Console.WriteLine("Monday");
//else if (num == 1) Console.WriteLine("Mon");
//else if (num == 2) Console.WriteLine("Tue");
//else if (num == 3) Console.WriteLine("Wed");
//else if (num == 4) Console.WriteLine("Thu");
//else if (num == 5) Console.WriteLine("Fri");
//else if (num == 6) Console.WriteLine("Sat");
//else if (num == 7) Console.WriteLine("Sun");
//else if (num < 0 ) Console.WriteLine("Я те чо шаман?");
//else Console.WriteLine("Ты по-моему попутал");
string a = Console.ReadLine()!;
switch (a)
{
    case "1":
    Console.Write("Понедельник");
    break;
    case "2":
    Console.Write("Вторник");
    break;
    case "3":
    Console.Write("Среда");
    break;
    case "4":
    Console.Write("Четверг");
    break;
    case "5":
    Console.Write("Пятница");
    break;
    case "6":
    Console.Write("Суббота");
    break;
    case "7":
    Console.Write("Воскресенье");
    break;
    default:
    Console.Write("Такого дня недели нет");
    break;