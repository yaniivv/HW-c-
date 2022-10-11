Console.WriteLine("Введите трёхзначное число:");
int des = Convert.ToInt32(Console.ReadLine());

int Num(int result)
{
 if(des<100)
  {
    Console.WriteLine("Error");
  }
  else
  {
    while(des < 1000) des /= 10; 
    {
     Console.WriteLine(des % 10);
    }
  }
}
Num();

