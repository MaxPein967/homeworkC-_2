// Напишите программу, которая принимает 
//на вход трехзначное число и на выходе 
//показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <= 999)
{
    Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");
}
else
	Console.WriteLine("Число не трёхзначное");

Console.WriteLine();