// Задача 26: Напишите программу, которая 
// принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitsInNumber(int num)
{
    int digits = 0;
    while (num != 0)
    {
        digits++;
        num = num / 10;
    }
    return digits == 0 ? 1 : digits;
}

int result = DigitsInNumber(number);
Console.WriteLine($"Количество цифр в числе {number}: {result}");
