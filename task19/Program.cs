// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом
static void InitNumberByUser(ref int userNumber)
{
    try
    {
        Console.Write("Введите целое пятизначное число: ");
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

int Lenght = 5;
int[] dijits = new int[Lenght];
int intermediateNumber = userNumber;
for (int index = 0; index < Lenght; index++)
{
    dijits[index] = intermediateNumber % 10;
    intermediateNumber = (intermediateNumber -  dijits[index]) / 10;
}

string Label = "да";
for (int index = 0; index < Lenght; index++)
{
    if (dijits[index] != dijits[Lenght - index - 1])
    {
        Label = "нет";
    }
}

Console.Write(Label);
