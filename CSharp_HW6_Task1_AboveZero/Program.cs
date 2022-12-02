// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int[] FillArrayByUser(int sizeOfArray)
{
    int[] arr = new int[sizeOfArray];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число массива: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int AmountOfElementsAboveZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите длину массива: ");
int[] array = FillArrayByUser(int.Parse(Console.ReadLine()));

PrintArray(array);

Console.WriteLine($"Количество чисел в массиве больше нуля равна: {AmountOfElementsAboveZero(array)}");