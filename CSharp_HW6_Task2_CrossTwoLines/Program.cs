// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine($"Введите значение b1, k1, b2 и k2 для нахождения точки пересечения двух прямых, \nзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");

double[] arrayBK = new double[4];
for (int i = 0; i < arrayBK.Length; i++)
{
    arrayBK[i] = double.Parse(Console.ReadLine());
}

double crossX = 0;
double crossY = 0;

if (arrayBK[1] == arrayBK[3])
{
    Console.WriteLine("При заданных параметрах прямые параллельны и не имеют точки пересеченя.");
}
else
{
    crossX = (arrayBK[2] - arrayBK[0]) / (arrayBK[1] - arrayBK[3]);
    crossY = arrayBK[1] * (arrayBK[2] - arrayBK[0]) / (arrayBK[1] - arrayBK[3]) + arrayBK[0];
    Console.WriteLine($"Точка пересечения двух прямых: ({crossX}; {crossY})");
}
