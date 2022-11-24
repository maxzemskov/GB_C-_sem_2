
Console.Clear();
Console.WriteLine("Введите трехзначное число");
		int a = int.Parse(Console.ReadLine());
	if (a < 1000 && a > 100)
		{
			int b = a / 10;
			int c = b % 10;
			Console.WriteLine($"число под индексом 1 - {c}");
		}
	else
		Console.WriteLine("введено не 3х значное число");

			
