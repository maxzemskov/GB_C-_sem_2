Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

if (a < 100)
	Console.WriteLine("Третья цифра отсутствует");
else
{	
	while (a >= 1000)
	{
		a = a / 10;
	}	
int b = a % 10;
Console.WriteLine($"Число с индексом 2 - {b}");	
}	
