// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//ДЗ 2:
//Сделать небольшой каталог пользователей (от 3 до 5)
//С консоли вводятся данные о пользователе (не менее двух вариантов)
//данные записываются в массив (либо двумерный, либо массив массивов, либо несколько разных массивов)
//По окончанию запросить у пользователя какого человека он хочет вывести


Console.WriteLine(" Введите фамилию ");
string? surname1 = Console.ReadLine();
Console.WriteLine("Введите возраст");
string? age1 = Console.ReadLine();
Console.WriteLine(" Введите количество детей ");
string? kol1 = Console.ReadLine();

Console.WriteLine(" Введите фамилию ");
string? surname2 = Console.ReadLine();
Console.WriteLine("Введите возраст");
string? age2 = Console.ReadLine();
Console.WriteLine(" Введите количество детей ");
string? kol2 = Console.ReadLine();

Console.WriteLine("Введите фамилию");
string? surname3 = Console.ReadLine();
Console.WriteLine("Введите возраст");
string? age3 = Console.ReadLine();
Console.WriteLine(" Введите количество детей ");
string? kol3 = Console.ReadLine();

Console.WriteLine(" Введите фамилию ");
string? surname4 = Console.ReadLine();
Console.WriteLine("Введите возраст");
string? age4 = Console.ReadLine();
Console.WriteLine("Введите количество детей");
string? kol4 = Console.ReadLine();

//int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };


string?[,] people = new[,] { { surname1, age1, kol1, }, { surname2, age2, kol2, }, { surname3, age3, kol3, }, { surname4, age4, kol4, } };

Console.WriteLine("Кого ищем?");
string? chel = Console.ReadLine();

int man = Convert.ToInt32(chel);
Console.WriteLine($"Фамилия {people}" + $"возрастХ{people}" + $"количество детей{people}");
