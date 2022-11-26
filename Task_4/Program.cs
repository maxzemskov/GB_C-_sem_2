Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = a;
int max1 = 0;
int max2 = 0;

while (a % 10 > 0)
{
a = a / 10;
}
a = a / 10;

while (a > 0)
{
	if (a % 10 > max1)
	{
		max1 = a % 10;
	}
	a = a / 10;
}

while (b > 0)
{	
	if (b % 10 > max2 && b % 10 != max1)
	{
		max2 = b % 10;
	}
	b = b / 10;
}

Console.WriteLine($"Второй максимум равен {max2}");