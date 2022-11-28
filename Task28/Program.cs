// Задача 28: Напишите программу, которая
// принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Product(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i; 
    }
    return result;
}

if (number > 0)
{
    int product = Product(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} равна {product}");
}
else Console.WriteLine("Введите число больше 0");
