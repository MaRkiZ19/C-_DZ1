//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 0;
int b = 0;
System.Console.WriteLine("add number one");
a = int.Parse(Console.ReadLine());
System.Console.WriteLine("add number two");
b = int.Parse(Console.ReadLine());

if (a > b)
{
    System.Console.Write("largest number ");
    System.Console.WriteLine( a );
    System.Console.Write("smallest number ");
    System.Console.WriteLine( b );
}
else
{
    System.Console.Write("largest number ");
    System.Console.WriteLine( b );
    System.Console.Write("smallest number ");
    System.Console.WriteLine( a );
}

