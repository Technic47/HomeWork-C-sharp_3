//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int[] A = {3,6,8};
int[] B = {2,1,-7};
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