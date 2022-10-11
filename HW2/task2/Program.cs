// Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

void Num(double result)
{
  
  if(num<100)
  {
    Console.WriteLine("Error");
  }
  else
  {
    num = num % 100;
    Console.WriteLine(num);
  }
  else
  {
    while(num < 1000)
    {
      num = num % 100;
      Console.WriteLine(num);
     break;
    }
}

Num(num);