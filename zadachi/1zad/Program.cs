
// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число:");
int N = Convert.ToInt32(Console.ReadLine());

void Num(int num)
{

    if (N < 100)
{
    Console.WriteLine("Error");
}
else
{
    while (N < 1000)
{
    N = N % 10;
    Console.WriteLine(N);
    break;
}
}
return;
}

Num(N);