//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 99999)
{
    Console.WriteLine("Введеное число не пятизначное!");
}
int [] j = {1, 4, 2, 1, 2};
for (int i = j.lenght-1; i > 0; i++)
{
    Console.WriteLine(j[i]);
}

if (j[i] = num) 
{
     Console.WriteLine("Введенное число является палиндромом");
}
else 
{
    Console.WriteLine("Введенное число не является палиндромом");
}



//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите первый координат оси x: ");
double x = Convert.ToInt32(Console.ReadLine(" ,"));
Console.WriteLine("Введите второй координат оси x: ");
ddouble x = Convert.ToInt32(Console.ReadLine(" ,"));
Console.WriteLine("Введите третий координат оси x: ");
double x = Convert.ToInt32(Console.ReadLine(" ,"));
Console.WriteLine("Введите первый координат оси y: ");
double y = Convert.ToInt32(Console.ReadLine(" ,"));
Console.WriteLine("Введите второй координат оси y: ");
double y = Convert.ToInt32(Console.ReadLine(" ,"));
Console.WriteLine("Введите третий координат оси y: ");
double y = Convert.ToInt32(Console.ReadLine(" ,"));

double res = Console.WriteLine(Math.Sqrt(Math.Pow((x2-x1),2)+…+Math.Pow((z2-z1),2));


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

