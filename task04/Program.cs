//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = 0;
System.Console.WriteLine("add N ");
N = int.Parse(Console.ReadLine());

System.Console.WriteLine("Исходный массив");

int [] numbers = new int[N];
int lenght = numbers.Length;
int index = 0;
int first = 0;
while (index<lenght)
{
    numbers[first]=first+1;
    if (numbers[first] %2 == 0)
    {
        System.Console.WriteLine(numbers[first]);
    }
    index++;
    first++;
}

