// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

int SumOfOddNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0)
            sum = sum + array[i];
    return sum;
}

void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
}

System.Console.WriteLine("Введите длинну массива: ");
int lenght = int.Parse(Console.ReadLine() !);
int[]array = new int[lenght];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Сумма элементов, стоящих на нечетных позииях = {SumOfOddNumbers(array)}");