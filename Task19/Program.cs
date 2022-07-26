//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int[] array = {0,0,0,0,0};
int ost = 0;

int number = 0;

Console.WriteLine("Enter 5 digit number: ");
string userenter = Console.ReadLine();

bool enter = int.TryParse(userenter, out number);
if (enter)
{
    for (int i = 0; i < array.Length; i++)
    {
        ost = number % 10;
        number = number / 10;
        array[i] = ost;
        //Console.Write(array[i]);
    }
    if ((array[0] == array[4]) && (array[1] == array[3]))
    {
        Console.WriteLine("True");
    }
    else 
    {
        Console.WriteLine("False");
    }
}
if (!enter)
{
    Console.Write("Wrong input");
}