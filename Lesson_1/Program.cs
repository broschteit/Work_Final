// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите первое число: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int two = Convert.ToInt32(Console.ReadLine());
if (one == two)
    {
    Console.WriteLine("Введенные числа равны! ");
        }
else if (one > two)
    {
    Console.WriteLine("Первое число больше второго");
    }
else Console.WriteLine ("Второе число больше первого");
return;

// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int two = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int three = Convert.ToInt32(Console.ReadLine());
int max = one;
if (two > one)
    int max = two;
if (three > max)
    int max = three;
return;


// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    Console.WriteLine("Число четное!");
else Console.WriteLine("Число не четное!");
return;
