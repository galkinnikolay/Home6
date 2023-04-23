// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами (длина массива 5 элементов). Найдите сумму элементов, 
// стоящих на нечётных индексах (индексы с нуля).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] array = new int[5]; 

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-100, 100);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}

int sum = 0;
for (int i = 0; i < array.Length; i+=2)
{
    sum = sum + array[i];
}

Console.WriteLine();
Console.WriteLine($"Сумма нечётных индексов: {sum}");