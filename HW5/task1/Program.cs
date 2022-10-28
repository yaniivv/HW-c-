//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] numbers = new int[10];

void GetArray(int[] array, int min, int max){
for (int i = 0; i<array.Length; i++ ){
array[i] = new Random().Next(min, max);
}
}
void WriteArray(int[] array){
for (int i = 0; i<array.Length; i++ ){
Console.Write(array[i] + " ");
}
}

int QuantityPositive(int[] array){
int quantity = 0;
for (int i = 0; i<array.Length; i++ ){
if (array[i] % 2 == 0)
{
quantity++;
}
}
return quantity;
}

GetArray(numbers, 100, 1000);
WriteArray(numbers);

int quantity = QuantityPositive(numbers);
Console.Write($"-> {quantity}");