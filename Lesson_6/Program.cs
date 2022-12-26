//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается
//при помощи ввода слова "stop"
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");

int counts = 0;

while (true)
{
    string message = Console.ReadLine();
    if (message  == "stop")                                     
    {
        break;
    }
    else
    {
        double.TryParse(message, out double EnterNumber);       
        if (EnterNumber > 0)                                     
        {                                                        
            counts++;                                           
        }
    }
}

Console.Write(counts);


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadInt(string message)                        
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());    
}

double b1 = ReadInt("Введите число: ");
double k1 = ReadInt("Введите число: ");
double b2 = ReadInt("Введите число: ");
double k2 = ReadInt("Введите число: ");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;
    Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}