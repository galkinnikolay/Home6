// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами (длина массива 5 элементов). 
// Напишите программу, которая покажет количество чётных чисел 
// в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[arraySize]; 

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(99, 1000);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}

int even = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        even = even + 1;
    }
}

Console.WriteLine($"Четных чисел: {even}");