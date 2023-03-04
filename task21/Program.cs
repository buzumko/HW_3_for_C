// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
static void InitCoordinatesByUser(ref int x, ref int y, ref int z)
{
    try
    {
        Console.Write("Введите X: ");
        x = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y: ");
        y = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Z: ");
        z = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных {exc.Message}");
        return;
    }
}

////////

Console.Clear();
int Xa = 0, Ya = 0, Za = 0, Xb = 0, Yb = 0, Zb = 0;
Console.WriteLine("Для точки A");
InitCoordinatesByUser(ref Xa, ref Ya, ref Za);
Console.WriteLine("Для точки B");
InitCoordinatesByUser(ref Xb, ref Yb, ref Zb);

// считаем по формуле длины ввектора
// не вижу смысла оформлять в фукнцию то, что делается в программе 1 раз
double distantAB = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));

Console.WriteLine(distantAB);
