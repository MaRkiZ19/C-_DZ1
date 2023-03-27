//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int N = 0;
System.Console.WriteLine("add N ");
N = int.Parse(Console.ReadLine());

if (N%2==0)
{
    System.Console.WriteLine("Even");
}
else
{
    System.Console.WriteLine("not even");
}
