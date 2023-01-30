// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что 
//третьей цифры нет.

Console.Clear();

int Number = new Random().Next(1, 2000);
Console.WriteLine();
Console.WriteLine($"Число: {Number}");

if (Number / 100 > 0)
{
    if(Number > 999)
    {
        Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 10 % 10}");
    }
    else
    {
        Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number % 10}");
    }
}
else
{
    Console.WriteLine($"У числа {Number} нет третьей цифры");
}

Console.WriteLine();

