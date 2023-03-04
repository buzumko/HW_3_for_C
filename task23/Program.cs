// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
static void InitNumberByUser(ref int userNumber)
{
    try
    {
        Console.Write("Введите целое число: ");
        userNumber = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных {exc.Message}");
        return;
    }
}

////// сама программа
Console.Clear();

int userNumber = 0;
InitNumberByUser(ref userNumber);

///////

for (int index = 1; index <= userNumber; index++)
{
    Console.Write($"{Math.Pow(index, 3)} ");
}
