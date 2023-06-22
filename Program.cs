 /*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double Degree (double x, double y)
{
double count = 1;
double result = 1;
   while(count <= y)
   {
    result = result*x;
    count++;
   }
  return result;
}

int x = InputNum("Введите число: ");
int y = InputNum("Введите степень: ");
double deg = Degree(x, y);
Console.WriteLine(deg); */
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
/*
int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Sum(int value)
{
    int result = 0;
    result += value % 10;
    value /= 10;
    if(value > 0)
    {
        result += Sum(value);
    }
    return result;
}

int x = InputNum("Введите число: ");
int sum = Sum(x);
Console.WriteLine(sum); */
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
int[] ArrayRand(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i]+" ");
    }
}
int len = InputNum("Введите длину массива: ");
int[] arr = ArrayRand(len);
PrintArray(arr);