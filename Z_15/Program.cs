// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Clear();
string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    number = number - 1;
    if ((5 <= number) && (number<= 6))Console.WriteLine($" {daysOfWeek[number]} выходной ");
    else Console.WriteLine(daysOfWeek[number]);
}
else
    Console.WriteLine("Не является днем недели");

Console.WriteLine();