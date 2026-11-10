﻿int age1 = 20;
if (age1 >= 18) {
    Console.WriteLine("Доступ разрешён");
}
    Console.WriteLine("Программа продолжает работу");


int age2 = 20;
if (age2 >= 21) {
    Console.WriteLine("Доступ разрешён");
}
    Console.WriteLine("Программа продолжает работу");


int age3 = 15;
if (age3 >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
}

int age4 = 15;
if (age4 >= 18) {
    Console.WriteLine("Доступ разрешён");} else
{
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine($"До совершеннолетия: {18 - age4} года");
}
int age5 = 14;
if (age5 < 13)
{
    Console.WriteLine("Ребёнок");
}
else if (age5 < 18)
{
    Console.WriteLine("Подросток");
}
else
{
    Console.WriteLine("Взрослый");
}


int age6 = 14;
if (age6 < 13) {
    Console.WriteLine("Ребёнок");
} else if (age6 < 18) {
    Console.WriteLine("Подросток");
} else if (age6 >= 60) {
    Console.WriteLine("Пенсионер");
} else {
    Console.WriteLine("Взрослый");
}


int age7 = 16;
double height = 1.55;
bool hasAdult = true;
if (age7 >= 14 && height >= 1.5) {
    Console.WriteLine("Можно кататься");
} else {
    Console.WriteLine("Пока нельзя");
}
