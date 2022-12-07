//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num > 999)
    Console.WriteLine("Введеное число не трехзначное!");
else result = (num / 10) % 10;
    Console.WriteLine($"{result}");


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
    Console.WriteLine("Нет третьей цифры");
else {
    for (; num >= 1000; num = num/10);
    Console.WriteLine(num % 10);
}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//int weekdays = {1, 2, 3, 4, 5}; будни
//int weekends = {6, 7}; выходные

Console.WriteLine("Введите число в интервале от 1 до 7, пропорционально дням недели 1 - понедельник, 2 - вторник и т.д.: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7 || < 1)
    Console.WriteLine("Число не входит в диапазон от 1 до 7");
else if (num > 5)
    Console.WriteLine("Да, этот день выходной!");
    else Console.WriteLine("Прости друг, но сегодня все еще на работу, так как это будний день");


