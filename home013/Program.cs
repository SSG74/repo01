// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());

if (day > 5)
    Console.WriteLine("да, выходной");
else
    Console.WriteLine("нет, рабочий день");
