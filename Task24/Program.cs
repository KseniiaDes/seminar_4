// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i; // sum += i;
    }
    return sum;
}

if (number > 0)
{
    int result = Sum(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} равна {result}");
}
else Console.WriteLine("Введите число больше 0");