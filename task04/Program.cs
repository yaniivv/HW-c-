Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int D = Convert.ToInt32(Console.ReadLine());

int max = A;

if (A > max) max = A;
if (B > max) max = B;
if (D > max) max = D;

Console.Write("max = ");
Console.WriteLine(max);
