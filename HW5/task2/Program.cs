//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] numbers = new int[10];

void GetArray(int[] array, int min, int max)
{
    for (int i = 0; i<array.Length; i++ )
    {
        array[i] = new Random().Next(min, max);
    }
}
void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
        Console.Write(array[i] + " ");
    }
}

int SumBlock(int[] array)
{
    int sum = 0;
    for (int i = 0; i<array.Length; i++ )
    {
        if (array[i] % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
return sum;
}

GetArray(numbers, -100, 100);
WriteArray(numbers);

int sum = SumBlock(numbers);
Console.Write($"-> {sum}");