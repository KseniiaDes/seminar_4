// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int[8];
// 0  1  2  3  4  5  6  7
// 0, 0, 0, 0, 0, 0, 0, 0
// int[] array1 = {1,5,56,7,5};
// int[] array2 = new int [5] {1, 6, 9, 7 ,8};

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);
