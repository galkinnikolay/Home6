// Задача 3: Задайте массив из 8 случайных чисел из 
// промежутка [-9, 9]. Напишите программу получает на вход число 
// и определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[8]; 

for (int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-9, 10);
    array[i] = randomNumber;
    Console.Write(array[i] + " ");
}

Console.WriteLine();
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine()); 

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == x)
    {
        Console.WriteLine("Да");
        return;
    }   
}

Console.WriteLine("Нет");