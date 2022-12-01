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