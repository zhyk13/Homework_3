// Принимает на вход координаты двух точек и находит расстояние
// между ними в 3D прстранстве
double Distance3D(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    return Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By-Ay, 2) + Math.Pow(Bz - Az, 2)), 2);
}

int ReadData(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Ax = ReadData("Введите координату X у точки А: ");
int Ay = ReadData("Введите координату Y у точки А: ");
int Az = ReadData("Введите координату Z у точки А: ");
int Bx = ReadData("Введите координату X у точки B: ");
int By = ReadData("Введите координату Y у точки B: ");
int Bz = ReadData("Введите координату Z у точки B: ");
System.Console.WriteLine(Distance3D(Ax, Ay, Az, Bx, By, Bz));
