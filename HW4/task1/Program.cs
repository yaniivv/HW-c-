//опишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B

Console.WriteLine("Введите число A:");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int numB = Convert.ToInt32(Console.ReadLine());
int res = 1;

for(int i = 1; i <= numB; i++)
{
   res*= numA;
}
  Console.WriteLine($"{res} = {numA} ^ {numB}");


