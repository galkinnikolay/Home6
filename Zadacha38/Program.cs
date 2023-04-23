// Задача 38: Задайте массив вещественных чисел от -100 до 100 
// (длина массива 5 элементов). Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[5]; 

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-100, 100);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    max = array[i];
    if (min > array[i])
    min = array[i];
}

Console.WriteLine();
Console.WriteLine($"Маскимальное значение: {max}");
Console.WriteLine();
Console.WriteLine($"Минимальное значение: {min}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {max - min}");