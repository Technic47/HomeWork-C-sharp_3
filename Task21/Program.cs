//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int[] A = {0,0,0};
int[] B = {0,0,0};

Console.WriteLine("Write x y z coordinates for A");
Console.WriteLine("X:");
int x1 = int.Parse(Console.ReadLine());
A[0] = x1;
Console.WriteLine("Y:");
int y1 = int.Parse(Console.ReadLine());
A[1] = y1;
Console.WriteLine("Z:");
int z1 = int.Parse(Console.ReadLine());
A[2] = z1;

Console.WriteLine("Write x y z coordinates for B");
Console.WriteLine("X:");
int x2 = int.Parse(Console.ReadLine());
B[0] = x2;
Console.WriteLine("Y:");
int y2 = int.Parse(Console.ReadLine());
B[1] = y2;
Console.WriteLine("Z:");
int z2 = int.Parse(Console.ReadLine());
B[2] = z2;

int x = 0;
int y = 1;
int z = 2;
float dist = 0;

int SqrSum(int a)
{
    int result = (B[a] - A[a])*(B[a] - A[a]);
    return result;
}

dist = MathF.Sqrt(SqrSum(x) + SqrSum(y) + SqrSum(z));

Console.Write(dist);