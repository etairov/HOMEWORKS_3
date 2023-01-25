//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53
//------------------------------------------------------------------

    int ax = new Random().Next(-100, 100);
    int ay = new Random().Next(-100, 100);
    int az = new Random().Next(-100, 100);

    int bx = new Random().Next(-100, 100);
    int by = new Random().Next(-100, 100);
    int bz = new Random().Next(-100, 100);

double ourDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - by, 2));
    return result;
}

double distance = ourDistance(ax, ay, az, bx, by, bz);

Console.WriteLine($"Расстояние между точками ({ax},{ay},{az}) и ({bx},{by},{bz}) равно {distance:f3}");
