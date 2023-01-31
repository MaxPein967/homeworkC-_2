// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что 
//третьей цифры нет.

Console.Clear();

int n = new Random().Next(1, 2000);
Console.WriteLine();
Console.WriteLine($"Число: {n}");

Console.WriteLine(n>99 ? n.ToString()[2] : '-');

// if (Number / 100 > 0)
// {
//     if(Number > 999)
//     {
//         Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 10 % 10}");
//     }
//     else
//     {
//         Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number % 10}");
//     }
// }
// else
// {
//     Console.WriteLine($"У числа {Number} нет третьей цифры");
// }

// Console.WriteLine();
