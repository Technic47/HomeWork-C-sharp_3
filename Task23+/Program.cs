Console.WriteLine("Enter number:");
int N = int.Parse(Console.ReadLine());

int Cube(int i)
{
    int x = i*i*i;
    return x;
}
int i = 1;
while (Cube(i) <= N)
{
    Console.Write($"{Cube(i)}, ");
    i++;
}
