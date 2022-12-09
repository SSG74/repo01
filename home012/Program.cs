// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else{
{
    while (number > 1000)
    { number = number / 10;}
}
int number1 = number % 10;
Console. WriteLine($" третья цифра: {number1} ");}    