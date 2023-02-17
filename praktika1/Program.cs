Console.WriteLine(" Напишите имя");
Console.WriteLine(" 2 Hello, World!");
Console.WriteLine(" 2 Hello, World!");



//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();

Console.WriteLine("Введите X:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y:");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
    Console.WriteLine("1 четверть");
else if (x < 0 && y > 0)
    Console.WriteLine("2 четверть");
else if (x < 0 && y < 0)
    Console.WriteLine("3 четверть");
else if (x > 0 && y < 0)
    Console.WriteLine("4 четверть");
else
    Console.WriteLine("четверть не определена");


// Задача обратная по номеру четверти найти возможные координаты

Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
  Console.WriteLine("x > 0; y > 0");
}
else if (num == 2)
{
  Console.WriteLine("x < 0;y > 0");
}
else if (num == 3)
{
  Console.WriteLine("x < 0; y < 0");
}
else if (num == 4)
{
  Console.WriteLine("x > 0;y < 0");
}
else
  Console.WriteLine("четверть не существует");

// та же задача решение через свитч типа кейсы

Console.Clear();

Console.WriteLine("Введем номер четверти:");
int Chetv = int.Parse(Console.ReadLine());
switch (Chetv)
{
    case 1:
        Console.WriteLine("x>0 & y>0");
        break;
    case 2:
        Console.WriteLine("x<0 & y>0");
        break;
    case 3:
        Console.WriteLine("x<0 & y<0");
        break;
    case 4:
        Console.WriteLine("x>0 & y<0");
