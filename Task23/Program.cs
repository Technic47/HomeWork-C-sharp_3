/*Задача 23 Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел
*/

Console.WriteLine("Enter number:");
int N = int.Parse(Console.ReadLine()!);

int[] array = new int[N];

int Cube(int i)
{
    int x = i*i*i;
    return x;
}

for (int i = 0; i < N; i++)
{
    array[i] = Cube((i+1));
    Console.Write($"{array[i]} ");
}

