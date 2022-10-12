//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetNum(string text)
{
 Console.Write(text + ": ");
 double num = Convert.ToDouble(Console.ReadLine());
 return num;
}

void Print(double ax, double ay, double az, double bx, double by, double bz, double result)
{
    string output = "A|(" + ax + ", " + ay + ", " + az + "); B(" + bx + ", " + by + ", " + bz + ")| = " + result;
  Console.WriteLine(output);
}

double GetDis(double ax, double ay, double az, double bx, double by, double bz)
{
    double x = Math.Pow(ax - bx, 2); 
    double y = Math.Pow(ay - by, 2);
    double z = Math.Pow(az - bz, 2);
    double result = Math.Sqrt(x + y + z);
    return result;
}
double ax = GetNum("ax");
double ay = GetNum("ay");
double az = GetNum("az");
double bx = GetNum("bx");
double by = GetNum("by");
double bz = GetNum("bz");

double dis = GetDis(ax, ay, az, bx, by, bz);
Print(ax, ay, az, bx, by, bz, dis);