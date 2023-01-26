//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125
//------------------------------------

int GetNumber()
{
    Console.WriteLine("Введите любое число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int resultGetNumber = GetNumber();

    int N = resultGetNumber;
    Console.Write($"{resultGetNumber} --> ");

    for (int i = 1; i <= N; i++)
    {
        if (i < N) 
        {
             Console.Write($"{Math.Pow(i, 3)}, ");    
        }
        else
        {
             Console.Write($"{Math.Pow(i, 3)}");
        }
    }