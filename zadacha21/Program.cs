int x1 = ReadInt("Введите х для первой точки: ");
int y1 = ReadInt("Введите y для первой точки: ");
int z1 = ReadInt("Введите z для первой точки: ");
int x2 = ReadInt("Введите х для второй точки: ");
int y2 = ReadInt("Введите y для второй точки: ");
int z2 = ReadInt("Введите z для второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}