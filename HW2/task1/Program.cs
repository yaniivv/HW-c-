Console.WriteLine("Введите трёхзначное число:");
int des = Convert.ToInt32(Console.ReadLine());
string sec = Convert.ToString(des);

 void Num(int result)
 {
 if(des<100)
  {
    Console.WriteLine("Error");
  }
  else
  {
    Console.WriteLine("Вторая цифра этого числа: "+sec[1]);
  }
  else
  {
    while(des < 1000)
    {
     Console.WriteLine("-> "+sec[1]);
      break;
    }
  }

Num();

