//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumR(int num)
{
    int ind = Convert.ToString(num).Length;
    int result = 0;
    int prom = 0;

    for (int i = 0; i < ind; i++){
      prom = num - num % 10;
      result = result + (num - prom);
      num = num / 10;
    }
   return result;
}

int sum = SumR(num);
Console.WriteLine($"{num} -> {sum}");
