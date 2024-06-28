// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0
// и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

System.Console.WriteLine("Введите координаты точки x, y через пробел: ");
string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x == 0)
    System.Console.WriteLine("Точка находится на оси ординат Y");
if (y == 0)
    System.Console.WriteLine("Точка находится на оси абсцисс X");
else
{
    if (x > 0 && y > 0)
        System.Console.WriteLine("Точка находится в I квадранте");
    if (x < 0 && y > 0)
        System.Console.WriteLine("Точка находится во II квадранте");
    if (x < 0 && y < 0)
        System.Console.WriteLine("Точка находится в III квадранте");
    if (x > 0 && y < 0)
        System.Console.WriteLine("Точка находится в IV квадранте");
}