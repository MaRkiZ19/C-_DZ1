//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


/*int a = 0;
int b = 0;
int c = 0;
System.Console.WriteLine("add number one");
a = int.Parse(Console.ReadLine());
System.Console.WriteLine("add number two");
b = int.Parse(Console.ReadLine());
System.Console.WriteLine("add number three");
c = int.Parse(Console.ReadLine());

int max = 0;

if (a > b && a > c)
{
    max = a;
}
else if (b > c)
{
    max = b;
}
else 
{
    max = c;
}
System.Console.Write("max number: ");
System.Console.WriteLine(max);
*/

int a = 0;
int b = 0;
int c = 0;
System.Console.WriteLine("add number one");
a = int.Parse(Console.ReadLine());
System.Console.WriteLine("add number two");
b = int.Parse(Console.ReadLine());
System.Console.WriteLine("add number three");
c = int.Parse(Console.ReadLine());

int max = 0;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;


System.Console.Write("max number: ");
System.Console.WriteLine(max);

