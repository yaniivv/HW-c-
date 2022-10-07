// Напишите метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int getnum(string text)
{
    Console.Write(text + ": ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

