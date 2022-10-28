// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arrayNew = new double[10];
  for (int i = 0; i < arrayNew.Length; i++ )
  {
    arrayNew[i] = new Random().Next(1, 100);
    Console.Write(arrayNew[i] + " ");
  }

double maxNumber = arrayNew[0];
double minNumber = arrayNew[0];

  for (int i = 1; i < arrayNew.Length; i++)
  {
    if (maxNumber < arrayNew[i])
    {
      maxNumber = arrayNew[i];
    }
        if (minNumber > arrayNew[i])
    {
      minNumber = arrayNew[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.Write($"\n-> {decision}");



