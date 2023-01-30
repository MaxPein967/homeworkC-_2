// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.(минимум, максимум, равны)

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();

int Number = new Random().Next(10, 100);
int Max = 0;
int Min = 0;

int MaxNum()
{
    int Num1 = Number / 10;
    int Num2 = Number % 10;
    if (Num1 > Num2)
    {
        Max = Num1;
    }
    else
    {
        Max = Num2;
    }
    return Max;
}
int MinNum()
{
    int Num1 = Number / 10;
    int Num2 = Number % 10;
    if (Num1 < Num2)
    {
        Min = Num1;
    }
    else
    {
        Min = Num2;
    }
    return Min;
}

MaxNum();
MinNum();
if(Min != Max) 
{
    Console.WriteLine($"В числе {Number} max = {Max}, min = {Min}");
}
else
{
     Console.WriteLine($"В числе {Number} цифры равны");
}

Console.WriteLine();